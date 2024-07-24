using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using AWMS.dapper;
using AWMS.dapper.Repositories;
using AWMS.dto;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.XtraVerticalGrid;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmItemLoc : XtraForm
    {
        private readonly IPackingListDapperRepository _packingListDapperRepository;
        private readonly IPackageDapperRepository _packageDapperRepository;
        private readonly IUnitDapperRepository _unitDapperRepository;
        private readonly IScopeDapperRepository _scopeDapperRepository;
        private readonly ILocationDapperRepository _locationDapperRepository;
        private readonly IItemDapperRepository _itemDapperRepository;
        private readonly ILocItemDapperRepository _locitemDapperRepository;
        private int itemId;
        private int LASTPKID;
        private decimal itemQty;
        private int repositorylocationId = 0;
        private int locationId = 1;
        private bool isNewRowAdded = false;

        public frmItemLoc(IPackingListDapperRepository packingListDapperRepository, IUnitDapperRepository unitDapperRepository,
            IScopeDapperRepository scopeDapperRepository, ILocationDapperRepository locationDapperRepository,
            IPackageDapperRepository packageDapperRepository, IItemDapperRepository itemDapperRepository,ILocItemDapperRepository locItemDapperRepository)
        {
            InitializeComponent();
            this._packingListDapperRepository = packingListDapperRepository;
            this._unitDapperRepository = unitDapperRepository;
            this._scopeDapperRepository = scopeDapperRepository;
            this._locationDapperRepository = locationDapperRepository;
            this._packageDapperRepository = packageDapperRepository;
            this._itemDapperRepository = itemDapperRepository;
            this._locitemDapperRepository=locItemDapperRepository;
            LookUPLoad();

            gridcontrolItem.DoubleClick += gridcontrol_DoubleClick;
            gridView1.CellValueChanged += gridView1_CellValueChanged;

            chkEdit.CheckedChanged += chkEdit_CheckedChanged;
            chkEdit_CheckedChanged(null, null);
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = !chkEdit.Checked;
        }

        private async void LookUPLoad()
        {
            try
            {
                lookUpEditPl.Properties.DataSource = await _packingListDapperRepository.GetAllPlNameAsync();
                lookUpEditLocation.Properties.DataSource = await _locationDapperRepository.GetAllAsync();
                repositoryItemLookUpEditunit.DataSource = await _unitDapperRepository.GetAllAsync();
                repositoryItemLookUpEditScope.DataSource = await _scopeDapperRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading lookup data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lookUpEditPl_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditPl.EditValue == null || string.IsNullOrWhiteSpace(lookUpEditPl.EditValue.ToString()))
            {
                return;
            }

            try
            {
                int plid = Convert.ToInt32(lookUpEditPl.EditValue);

                // Get packages
                repositoryItemLookUpEditPK.DataSource = _packageDapperRepository.GetPackageByPLId(plid);

                // Fill Grid
                var items = await _itemDapperRepository.GetAllItemByPlIdAsync(plid);
                var observableItems = new ObservableCollection<ItemDto>(items);
                gridcontrolItem.DataSource = observableItems;

                // Enable the gridcontrol
                gridcontrolItem.Enabled = true;

                var lastPackage = _packageDapperRepository.GetLastPackage(plid);
                int countPK = _packageDapperRepository.GetPackageCount(plid);
                int LASTPKID = _packageDapperRepository.GetLastPKID(plid);

                lblcount.Text = "Count Of PK : " + countPK;
                lblLastPK.Text = "Last PK : " + lastPackage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading package data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void gridcontrol_DoubleClick(object sender, EventArgs e)
        {
            GridControl gridControl = sender as GridControl;

            if (gridControl != null && gridView1 != null)
            {
                GridHitInfo hitInfo = gridView1.CalcHitInfo(gridControl.PointToClient(Control.MousePosition));

                if (hitInfo.RowHandle >= 0)
                {
                    try
                    {
                        itemId = (int)gridView1.GetRowCellValue(hitInfo.RowHandle, "ItemId");
                        itemQty = Convert.ToDecimal(gridView1.GetRowCellValue(hitInfo.RowHandle, "Qty"));

                        repositoryItemLookUpEditLocation.DataSource = await _locationDapperRepository.GetAllAsync();
                        // Retrieve locItems and update GridControl
                        var locitems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(itemId);
                        var bindingListLocItems = new BindingList<LocItemDto>(locitems.ToList());
                        gridControl1.DataSource = bindingListLocItems;

                        xtraTabControl1.SelectedTabPage = xtraTabPage2;
                        labelControl7.Text = "ItemID: " + itemId.ToString();
                        labelControl9.Text = "ItemQty: " + itemQty.ToString();
                        labelControl8.Text = "";

                        //Switch between XtraTabPages based on ItemId
                        if (itemId == 1)
                        {
                            xtraTabControl1.SelectedTabPage = xtraTabPage1;
                        }
                        else if (itemId == 2)
                        {
                            xtraTabControl1.SelectedTabPage = xtraTabPage2;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while handling the double click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view == null || e.RowHandle < 0) return;

                var modifiedItem = view.GetRow(e.RowHandle) as ItemDto;

                if (modifiedItem != null)
                {
                    int locationId = 1; // مقدار پیش‌فرض

                    if (lookUpEditLocation.EditValue != null)
                    {
                        int tempLocationId;
                        if (int.TryParse(lookUpEditLocation.EditValue.ToString(), out tempLocationId))
                        {
                            locationId = tempLocationId;
                        }
                    }


                    if (isNewRowAdded)
                    {
                        var newItemId = await _itemDapperRepository.AddItemWithAddLocitemWithTriggerAsync(modifiedItem, locationId);
                        isNewRowAdded = false; // بازنشانی پرچم پس از اضافه کردن

                        modifiedItem.ItemId = newItemId;
                        view.RefreshRow(e.RowHandle);
                    }
                    else
                    {
                        await _itemDapperRepository.UpdateAsync(modifiedItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                var observableItems = gridcontrolItem.DataSource as ObservableCollection<ItemDto>;

                if (observableItems != null)
                {
                    int plid = Convert.ToInt32(lookUpEditPl.EditValue);
                    LASTPKID = _packageDapperRepository.GetLastPKID(plid);

                    // Create new item
                    var newItem = new ItemDto
                    {
                        EnteredDate = DateTime.Now,
                        PKID = LASTPKID,
                        UnitID = 1, // Set default value or based on your needs
                        ScopeID = 1
                    };

                    // Add new item to collection
                    observableItems.Add(newItem);
                    isNewRowAdded = true;

                    // Refresh the grid view
                    gridView1.RefreshData();

                    // Focus on the new row
                    int newRowHandle = gridView1.GetRowHandle(observableItems.Count - 1);
                    gridView1.FocusedRowHandle = newRowHandle;
                    gridView1.ShowEditor();
                    gridView1.MakeRowVisible(newRowHandle, true);

                    MessageBox.Show("New item added and waiting to be saved.", "New Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btndeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected rows
                int[] selectedRows = gridView1.GetSelectedRows();
                if (selectedRows.Length == 0)
                {
                    MessageBox.Show("Please select items to delete.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected items?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var itemsToDelete = new List<ItemDto>();

                    foreach (var rowHandle in selectedRows)
                    {
                        var item = gridView1.GetRow(rowHandle) as ItemDto;
                        if (item != null)
                        {
                            itemsToDelete.Add(item);
                        }
                    }

                    // Delete the items from the database
                    await _itemDapperRepository.DeleteMultipleItemsWithTransactionAsync(itemsToDelete);

                    // Remove the items from the observable collection
                    var observableItems = gridcontrolItem.DataSource as ObservableCollection<ItemDto>;
                    if (observableItems != null)
                    {
                        foreach (var item in itemsToDelete)
                        {
                            observableItems.Remove(item);
                        }
                        gridView1.RefreshData();
                    }

                    MessageBox.Show("Items deleted successfully.", "Items Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /////////////////// End Of Item , Start LocItem


        private async void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
                GridView view = sender as GridView;

                if (e.RowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                {   
                    var newLocItem = view.GetRow(e.RowHandle) as LocItemDto;
                    if (newLocItem != null)
                    {
                        newLocItem.ItemId = itemId; // Assuming itemId is a variable in your form
                        await _locitemDapperRepository.AddAsync(newLocItem);
                        var locitems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(itemId);
                        var bindingListLocItems = new BindingList<LocItemDto>(locitems.ToList());
                        gridControl1.DataSource = bindingListLocItems;
                }
                }
        }
      
        //private bool ValidateLocItem(LocItem locItem)
        //{
        //    try
        //    {
        //        // Calculate total QtyInLoc for the given ItemId
        //        decimal totalQtyInLoc = locItemBindingSource
        //            .Cast<LocItem>()
        //            .Where(item => item.ItemId == locItem.ItemId && item.LocItemID != locItem.LocItemID)
        //            .Sum(item => item.QtyInLoc ?? 0);

        //        // Validate if total QtyInLoc is within the limit (itemQty)
        //        bool isTotalQtyValid = totalQtyInLoc + (locItem.QtyInLoc ?? 0) <= itemQty + (locItem.OverQty ?? 0) - (locItem.ShortageQty ?? 0);

        //        // Display a message in label8 based on the validation results
        //        labelControl8.Text = isTotalQtyValid
        //            ? "Validation passed."
        //            : "Validation failed. Please check your data.";

        //        return isTotalQtyValid;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle or log the exception as needed
        //        MessageBox.Show($"An error occurred in ValidateLocItem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false; // Consider validation failed in case of an exception
        //    }
        //}





        private void repositoryItemLookUpEditLocation_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;

            if (editor != null)
            {
                // Get the selected item
                //Location selectedLocation = editor.GetSelectedDataRow() as Location;

                //// Perform actions based on the selected value
                //if (selectedLocation != null)
                //{
                //    // Access the LocationID property
                //    repositorylocationId = selectedLocation.LocationID;

                //    // Do something with the LocationID
                //    //MessageBox.Show($"Selected LocationID: {locationId}");
                //}
            }
        }
        //private void repositoryItemLookUpEditLocation_EditValueChanged(object sender, EventArgs e)
        //{
        //    LookUpEdit editor = sender as LookUpEdit;

        //    if (editor != null)
        //    {   ///hamid commmmmmmmmmmmmmmmmmmmment
        //        //// Get the selected item
        //        //Location selectedLocation = editor.GetSelectedDataRow() as Location;

        //        //// Perform actions based on the selected value
        //        //if (selectedLocation != null)
        //        //{
        //        //    // Access the LocationID property
        //        //    repositorylocationId = selectedLocation.LocationID;

        //        //    // Check if the location has already been registered in LocItem list
        //        //    bool isLocationRegistered = locItemBindingSource
        //        //        .Cast<LocItem>()
        //        //        .Any(item => item.LocationID == repositorylocationId);

        //        //    if (isLocationRegistered)
        //        //    {
        //        //        // Location is already registered, show a message or perform necessary actions
        //        //        MessageBox.Show("This location has already been registered.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        //        // You may want to clear the selection or handle it differently based on your requirements
        //        //        // Clear the Location editor's value to indicate that the location is not valid
        //        //        editor.EditValue = null;

        //        //        // Optionally, you can also set repositorylocationId to 0 or another value to indicate an invalid location
        //        //        repositorylocationId = 0;
        //        //    }
        //        //    else
        //        //    {
        //        //        // Location is not registered, continue with the selected location
        //        //        // You can perform additional actions if needed
        //        //    }
        //        //}
        //    }
        //}

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;

                // Check if the modified row is not a new row
                if (e.RowHandle >= 0)
                {    //hamid commmmmmmmmmmmmmmmmmmmmmmmmmment
                     //LocItem modifiedlocitem = view.GetRow(e.RowHandle) as LocItem;

                    //if (modifiedlocitem != null)
                    //{
                    //    // Validate the LocItem data
                    //    if (!ValidateLocItem(modifiedlocitem))
                    //    {
                    //        // Validation failed, set an error message
                    //        view.SetColumnError(view.Columns["Qty"], "Validation failed. Please check your data.");
                    //       // e.Valid = false; // Mark the row as invalid
                    //    }
                    //    else
                    //    {
                    //        //using (DatabaseContext _context = new DatabaseContext())
                    //        //{
                    //        //    ILocItemRepository locItemRepository = new LocItemService(_context);
                    //        //    locItemRepository.UpdateLocitem(modifiedlocitem);
                    //        //}
                    //        using (UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext()))
                    //        {
                    //            unitOfWork.LocItemRepository.UpdateLocitem(modifiedlocitem);
                    //            unitOfWork.Save();
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, "ItemId", itemId); // itemId should be accessible in this scope
        }

     
    }
}
