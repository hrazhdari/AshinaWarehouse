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
using AWMS.datalayer.Entities;

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
            IPackageDapperRepository packageDapperRepository, IItemDapperRepository itemDapperRepository, ILocItemDapperRepository locItemDapperRepository)
        {
            InitializeComponent();
            this._packingListDapperRepository = packingListDapperRepository;
            this._unitDapperRepository = unitDapperRepository;
            this._scopeDapperRepository = scopeDapperRepository;
            this._locationDapperRepository = locationDapperRepository;
            this._packageDapperRepository = packageDapperRepository;
            this._itemDapperRepository = itemDapperRepository;
            this._locitemDapperRepository = locItemDapperRepository;
            LookUPLoad();

            gridcontrolItem.DoubleClick += gridcontrol_DoubleClick;
            gridView1.CellValueChanged += gridView1_CellValueChanged;

            chkEdit.CheckedChanged += chkEdit_CheckedChanged;
            chkEdit_CheckedChanged(null, null);

            ///Locitem Section
            // رویداد برای محاسبه مقدار ستون محاسباتی
            gridView2.CustomUnboundColumnData += gridView2_CustomUnboundColumnData;
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
                        var itemOverQty = Convert.ToDecimal(gridView1.GetRowCellValue(hitInfo.RowHandle, "OverQty"));
                        var itemShoratgeQty = Convert.ToDecimal(gridView1.GetRowCellValue(hitInfo.RowHandle, "ShortageQty"));

                        repositoryItemLookUpEditLocation.DataSource = await _locationDapperRepository.GetAllAsync();
                        // Retrieve locItems and update GridControl
                        var locitems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(itemId);
                        var bindingListLocItems = new BindingList<LocItemDto>(locitems.ToList());
                        gridControl1.DataSource = bindingListLocItems;

                        xtraTabControl1.SelectedTabPage = xtraTabPage2;
                        labelControl7.Text = itemId.ToString();
                        labelControl9.Text = itemQty.ToString();
                        labelControl10.Text = itemOverQty.ToString();
                        labelControl11.Text = itemShoratgeQty.ToString();
                        labelControl16.Text = "...";
                        labelControl22.Text = "...";
                        labelControl19.Text = "...";
                        labelControl23.Text = "...";
                        labelControl21.Text = "...";
                        labelControl24.Text = "...";
                        labelControl8.Text = "";
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
                    // اگر مقدار Qty معتبر باشد، عملیات ذخیره‌سازی انجام شود
                    if (modifiedItem.Qty > 0)
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
                        ScopeID = 1,
                        OverQty = 0,
                        ShortageQty = 0,
                        DamageQty = 0,
                        IncorectQty = 0,
                        NIS = 0,
                        NetW = 0,
                        GrossW = 0
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

                    MessageBox.Show("New item added and waiting to be saved.\nPlease Enter The OverQty And ShortageQty first so that it is automatically inserted in LocItem Table, Otherwise You Have To Do It Manually.", "New Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridView2_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "QtyInLoc" && e.IsGetData)
            {
                LocItemDto locItem = (LocItemDto)e.Row;
                // محاسبه مقدار QtyInLoc
                decimal qtyInLoc = locItem.Qty ?? 0;
                qtyInLoc += locItem.OverQty ?? 0;
                qtyInLoc -= locItem.ShortageQty ?? 0;
                e.Value = qtyInLoc;
            }
        }
        private async void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && e.Column.FieldName == "LocationID")
            {
                int newLocationId = (int)e.Value;

                // دریافت ردیف فعلی
                var currentRow = view.GetRow(e.RowHandle) as LocItemDto;

                // مقدار پیش‌فرض لوکیشن (در اینجا 1 در نظر گرفته شده است)
                const int defaultLocationId = 1;

                // بررسی اینکه لوکیشن جدید ثبت شده است
                var existingLocItem = view.DataController.ListSource.Cast<LocItemDto>()
                    .FirstOrDefault(item => item.LocationID == newLocationId && item.LocItemID != currentRow.LocItemID);

                if (existingLocItem != null)
                {
                    if (newLocationId == defaultLocationId)
                    {
                        // اگر لوکیشن پیش‌فرض است، هیچ اقدامی انجام نمی‌دهیم
                        return;
                    }
                    else
                    {
                        // لوکیشن قبلاً ثبت شده است، نمایش پیام اطلاعاتی
                        MessageBox.Show("This location has already been registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // بازنشانی به مقدار قبلی (اختیاری)
                        // view.SetRowCellValue(e.RowHandle, "LocationID", currentRow.LocationID); // previousValue باید مقدار قبلی باشد
                        return;
                    }
                }

                // Validation for new LocationID
                if (newLocationId <= 0)
                {
                    MessageBox.Show("Please select a valid location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    view.SetRowCellValue(e.RowHandle, "LocationID", defaultLocationId); // بازنشانی به مقدار پیش‌فرض
                    return;
                }
            }

            // خواندن مقادیر از labelControl
            decimal labelControl9Value = decimal.TryParse(labelControl9.Text, out var qtyValue) ? qtyValue : 0;
            decimal labelControl10Value = decimal.TryParse(labelControl10.Text, out var overQtyValue) ? overQtyValue : 0;
            decimal labelControl11Value = decimal.TryParse(labelControl11.Text, out var shortageQtyValue) ? shortageQtyValue : 0;

            // دریافت لیست فعلی LocItems
            var locItems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(itemId); // itemId باید مقداردهی شده باشد

            // جمع مقادیر قبلی
            decimal totalQty = locItems.Sum(li => li.Qty ?? 0);
            decimal totalOverQty = locItems.Sum(li => li.OverQty ?? 0);
            decimal totalShortageQty = locItems.Sum(li => li.ShortageQty ?? 0);


            if (e.RowHandle >= 0)
            {
                var updatedLocItem = view.GetRow(e.RowHandle) as LocItemDto;
                if (updatedLocItem != null)
                {
                    // کسر مقدار قبلی از جمع کل
                    var oldLocItem = locItems.FirstOrDefault(li => li.LocItemID == updatedLocItem.LocItemID);
                    if (oldLocItem != null)
                    {
                        totalQty -= oldLocItem.Qty ?? 0;
                        totalOverQty -= oldLocItem.OverQty ?? 0;
                        totalShortageQty -= oldLocItem.ShortageQty ?? 0;
                    }
                    // اضافه کردن مقدار جدید به جمع کل
                    totalQty += updatedLocItem.Qty ?? 0;
                    totalOverQty += updatedLocItem.OverQty ?? 0;
                    totalShortageQty += updatedLocItem.ShortageQty ?? 0;

                    if (totalQty > labelControl9Value)
                    {
                        MessageBox.Show($"The total Qty ({totalQty}) exceeds the allowed amount in ItemQty ({labelControl9Value}).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (totalOverQty > labelControl10Value)
                    {
                        MessageBox.Show($"The total OverQty ({totalOverQty}) exceeds the allowed amount in OverQty ({labelControl10Value}).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (totalShortageQty > labelControl11Value)
                    {
                        MessageBox.Show($"The total ShortageQty ({totalShortageQty}) exceeds the allowed amount in ShortageQty ({labelControl11Value}).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    labelControl16.Text = totalQty.ToString("N2");
                    labelControl19.Text = totalOverQty.ToString("N2");
                    labelControl21.Text = totalShortageQty.ToString("N2");
                    labelControl22.Text = (Convert.ToDecimal(labelControl16.Text) - Convert.ToDecimal(labelControl9.Text)).ToString();
                    labelControl23.Text = (Convert.ToDecimal(labelControl19.Text) - Convert.ToDecimal(labelControl10.Text)).ToString();
                    labelControl24.Text = (Convert.ToDecimal(labelControl21.Text) - Convert.ToDecimal(labelControl11.Text)).ToString();
                    // به‌روزرسانی رکورد قبلی
                    await UpdateLocItemAsync(updatedLocItem);
                }
            }
        }

        private async Task UpdateLocItemAsync(LocItemDto locItem)
        {
            try
            {
                // به‌روزرسانی رکورد در پایگاه داده
                await _locitemDapperRepository.UpdateAsync(locItem);

                // بازیابی داده‌های به‌روز شده
                var locItems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(locItem.ItemId);

                // به روزرسانی نمایش GridControl
                var bindingListLocItems = new BindingList<LocItemDto>(locItems.ToList());
                gridControl1.DataSource = bindingListLocItems;
            }
            catch (Exception ex)
            {
                // ثبت خطا
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemLookUpEditLocation_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;

            if (editor != null)
            {
                // Get the selected item
                Location selectedLocation = editor.GetSelectedDataRow() as Location;

                // Perform actions based on the selected value
                if (selectedLocation != null)
                {
                    // Access the LocationID property
                    repositorylocationId = selectedLocation.LocationID;

                    // Optionally, you can perform actions here if needed
                }
            }
        }

        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                // تنظیم مقادیر پیش‌فرض برای ردیف‌های جدید
                view.SetRowCellValue(e.RowHandle, "ItemId", itemId); // itemId باید در این بخش قابل دسترسی باشد
                view.SetRowCellValue(e.RowHandle, "Qty", 0); // مقدار پیش‌فرض برای Qty
                view.SetRowCellValue(e.RowHandle, "OverQty", 0); // مقدار پیش‌فرض برای OverQty
                view.SetRowCellValue(e.RowHandle, "ShortageQty", 0); // مقدار پیش‌فرض برای ShortageQty
                view.SetRowCellValue(e.RowHandle, "DamageQty", 0); // مقدار پیش‌فرض برای DamageQty
                view.SetRowCellValue(e.RowHandle, "NISQty", 0); // مقدار پیش‌فرض برای NISQty
                view.SetRowCellValue(e.RowHandle, "RejectQty", 0); // مقدار پیش‌فرض برای RejectQty
                view.SetRowCellValue(e.RowHandle, "LocationID", 1); // تنظیم LocationID به 1 به‌عنوان مقدار پیش‌فرض
            }
        }

        private async void btnAddNewLocItem_Click(object sender, EventArgs e)
        {
            GridView view = gridView2;

            if (view == null) return;

            var newLocItem = new LocItemDto
            {
                ItemId = itemId,
                Qty = 0,
                OverQty = 0,
                ShortageQty = 0,
                DamageQty = 0,
                NISQty = 0,
                RejectQty = 0,
                LocationID = 1 // باید از جایی که LocationID تنظیم می‌شود، مقداردهی شود
            };

            if (newLocItem.LocationID == null || newLocItem.LocationID == 0)
            {
                MessageBox.Show("Please select a valid location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // اضافه کردن به دیتابیس و بررسی موفقیت
            await _locitemDapperRepository.AddAsync(newLocItem);

            // اضافه کردن به GridView
            var locItems = await _locitemDapperRepository.GetLocItemsByItemIdAsync(itemId); // itemId باید مقداردهی شده باشد
            gridControl1.DataSource = new BindingList<LocItemDto>(locItems.ToList());
        }

        private async void btnDeleteLocItem_Click(object sender, EventArgs e)
        {
            // گرفتن آیتم‌های انتخاب شده از گرید ویو
            var selectedRows = gridView2.GetSelectedRows();
            var selectedLocItems = new List<LocItemDto>();

            foreach (var rowIndex in selectedRows)
            {
                var locItem = gridView2.GetRow(rowIndex) as LocItemDto;
                if (locItem != null)
                {
                    selectedLocItems.Add(locItem);
                }
            }

            if (selectedLocItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // تأیید حذف
            var result = MessageBox.Show("Are you sure you want to delete the selected items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _locitemDapperRepository.DeleteMultipleLocItemsWithTransactionAsync(selectedLocItems);
                    MessageBox.Show("Items deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // بروزرسانی گرید ویو بعد از حذف
                    foreach (var locItem in selectedLocItems)
                    {
                        var rowHandle = gridView2.FindRow(locItem);
                        if (rowHandle >= 0)
                        {
                            gridView2.DeleteRow(rowHandle);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
