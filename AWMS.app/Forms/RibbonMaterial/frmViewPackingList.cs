using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using AWMS.dapper;
using AWMS.dapper.Repositories;
using AWMS.dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Extensions.DependencyInjection;
using AWMS.core.Interfaces;
using AWMS.core.Services;
using Dapper;
using AWMS.app.Forms.RibbonUser;
using AWMS.app.Utility;
using DevExpress.XtraBars;

namespace AWMS.app.Forms.RibbonMaterial
{
    public partial class frmViewPackingList : XtraForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISupplierService _supplierService;
        private readonly IIrnService _irnService;
        private readonly IShipmentService _shipmentService;
        private readonly IMrService _mrService;
        private readonly IPoService _poService;
        private readonly IAreaUnitService _areaunitService;
        private readonly IVendorService _vendorService;
        private readonly IDesciplineService _desciplineService;
        private readonly IDescriptionForPkService _descriptionforpkService;
        private readonly IUnitDapperRepository _unitService;
        private readonly IScopeDapperRepository _scopeService;
        private readonly ILocationDapperRepository _locationRepository;
        private readonly IPackingListDapperRepository _packingRepository;
        private readonly IPackageDapperRepository _packageRepository;
        private readonly ILocItemDapperRepository _LocitemRepository;
        private readonly IItemDapperRepository _itemRepository;
        private readonly UserSession _session; // اضافه کردن UserSession

        int PLid;
        string PLname;
        private bool _isAllSelected = false;
        //private bool _isAllHoldSelected = false;

        public frmViewPackingList(ISupplierService supplierService, IServiceProvider serviceProvider, IIrnService irnService,
            IShipmentService shipmentService, IMrService mrService, IPoService poService, IAreaUnitService areaunitService,
            IVendorService vendorService, IDesciplineService desciplineService, IDescriptionForPkService descriptionforpkService,
            IUnitDapperRepository unitService, IScopeDapperRepository scopeDapperRepository, IPackageDapperRepository packageDapperRepository,
            ILocationDapperRepository locationDapperRepository, IPackingListDapperRepository packingListDapperRepository,
            ILocItemDapperRepository locitemRepository, IItemDapperRepository itemDapperRepository, int userId)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            this._supplierService = supplierService;
            this._irnService = irnService;
            _shipmentService = shipmentService;
            _mrService = mrService;
            _poService = poService;
            _areaunitService = areaunitService;
            _vendorService = vendorService;
            _desciplineService = desciplineService;
            _descriptionforpkService = descriptionforpkService;
            this._unitService = unitService;
            this._scopeService = scopeDapperRepository;
            this._locationRepository = locationDapperRepository;
            this._packingRepository = packingListDapperRepository;
            this._packageRepository = packageDapperRepository;
            this._LocitemRepository = locitemRepository;
            this._itemRepository = itemDapperRepository;
            _session = SessionManager.GetSession(userId); // گرفتن نشست کاربر بر اساس userId

            initGrid();
            _LocitemRepository = locitemRepository;
            checkEdit3_CheckedChanged(null, null);
        }
        async void initGrid()
        {


            if (gridControl1 != null)
            {
                try
                {
                    var data = await _packingRepository.GetAllAsync();
                    if (data != null)
                    {
                        // فرض می‌کنیم که dataSource، داده‌ها را فراهم می‌کند و به GridControl داده شده است
                        gridControl1.DataSource = data;

                        // مرتب‌سازی بر اساس ستون PLId به ترتیب نزولی
                        gridView1.SortInfo.Clear();
                        gridView1.SortInfo.Add(new GridColumnSortInfo(gridView1.Columns["PLId"], DevExpress.Data.ColumnSortOrder.Descending));

                        // اطمینان حاصل کنید که GridView داده‌ها دارد
                        if (gridView1.RowCount > 0)
                        {
                            // تنظیم نشانگر به اولین ردیف
                            gridView1.FocusedRowHandle = 0;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No data retrieved from the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Grid control is not initialized.");
            }



            repositoryItemLookUpEditirn.DataSource = _irnService.GetAllIrns();
            repositoryItemLookUpEditshipment.DataSource = _shipmentService.GetAllShipments();
            repositoryItemLookUpEditmr.DataSource = _mrService.GetAllMrs();
            repositoryItemLookUpEditpo.DataSource = _poService.GetAllPos();
            repositoryItemLookUpEditarea.DataSource = _areaunitService.GetAllAreaUnits();
            repositoryItemLookUpEditsupplier.DataSource = _supplierService.GetAllSuppliers();
            repositoryItemLookUpEditvendor.DataSource = _vendorService.GetAllVendors();
            repositoryItemLookUpEditdescipline.DataSource = _desciplineService.GetAllDesciplines();
            repositoryItemLookUpEditdescriptionForPk.DataSource = _descriptionforpkService.GetAllDescriptionForPks();
            repositoryItemLookUpEditunit.DataSource = _unitService.GetAll();
            repositoryItemLookUpEditscope.DataSource = _scopeService.GetAll();
            repositoryItemLookUpEditlocation.DataSource = await _locationRepository.GetAllAsync();
        }
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "RowNumber" && e.IsGetData)
            {
                e.Value = e.ListSourceRowIndex + 1;
            }
        }
        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "RowNumber" && e.IsGetData)
            {
                e.Value = e.ListSourceRowIndex + 1;
            }
        }
        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked) { gridView1.OptionsBehavior.ReadOnly = false; } else { gridView1.OptionsBehavior.ReadOnly = true; }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked) { gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False; } else { gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True; }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view != null && e.FocusedRowHandle >= 0)
            {
                // Assuming you have a property named PlName in your entity
                var plName = view.GetRowCellValue(e.FocusedRowHandle, "PLName");
                object plid = view.GetRowCellValue(e.FocusedRowHandle, "PLId");

                if (plName != null)
                {
                    // Set the font for the label if needed
                    labelControl3.Font = new Font("Tahoma", 9);
                    labelControl3.Text = $"Selected PlName: {plName.ToString()}";
                }

                int lastPK = _packageRepository.GetLastPackage(Convert.ToInt32(plid.ToString()));
                int CountPK = _packageRepository.GetPackageCount(Convert.ToInt32(plid.ToString()));
                lblcount.Text = "Count Of PK : " + CountPK;
                lblLastPK.Text = "Last PK : " + lastPK;
            }
        }


        private void btnAddIrn_Click(object sender, EventArgs e)
        {
            var frmIrn = _serviceProvider.GetRequiredService<Forms.frmSmall.frmIRN>();
            frmIrn.ShowDialog();
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            var frmship = _serviceProvider.GetRequiredService<Forms.frmSmall.frmShipment>();
            frmship.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var frmsupplier = _serviceProvider.GetRequiredService<Forms.frmSmall.frmSupplier>();
            frmsupplier.ShowDialog();
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            var frmvendor = _serviceProvider.GetRequiredService<Forms.frmSmall.frmVendor>();
            frmvendor.ShowDialog();
        }

        private void btnRefreshArchiveNO_Click(object sender, EventArgs e)
        {
            initGrid();
            XtraMessageBox.Show("All Data Refreshed ;)");
        }

        private async void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;

                // Check if the modified row is not a new row
                if (e.RowHandle >= 0)
                {
                    PackingListDto modifiedPackingList = view.GetRow(e.RowHandle) as PackingListDto;

                    if (modifiedPackingList != null)
                    {
                        try
                        {
                            // Update the entity using the repository method
                            var (success, errorMessage) = await _packingRepository.UpdateAsync(modifiedPackingList);

                            if (!success)
                            {
                                // Handle the case where the update was not successful
                                MessageBox.Show($"Failed to update PackingList. {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Update was successful
                                MessageBox.Show("PackingList updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle or log the exception as needed
                            MessageBox.Show($"An error occurred while updating PackingList: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            GridControl gridControl = sender as GridControl;

            if (gridControl != null && gridView1 != null)
            {
                GridHitInfo hitInfo = gridView1.CalcHitInfo(gridControl.PointToClient(Control.MousePosition));

                if (hitInfo != null && hitInfo.RowHandle >= 0)
                {
                    // Get the selected ItemId from the clicked row
                    if (hitInfo.RowHandle < gridView1.RowCount)
                    {
                        object plIdObject = gridView1.GetRowCellValue(hitInfo.RowHandle, "PLId");
                        if (plIdObject != null && plIdObject is int)
                        {
                            PLid = (int)plIdObject;
                            // Rest of your code
                            PLname = gridView1.GetRowCellValue(hitInfo.RowHandle, "PLName").ToString();

                            gridControl2.DataSource = await _packingRepository.AllItemSelectedPlAsync(PLid);

                            xtraTabControl1.SelectedTabPage = xtraTabPage2;
                            labelControl8.Text = "PLID:  " + PLid.ToString();
                            labelControl9.Text = "PLName:  " + PLname.ToString();

                            repositoryItemLookUpEditpk.DataSource = _packageRepository.GetPackageByPLId(PLid);
                            // مرتب‌سازی بر اساس یک ستون
                            gridView2.SortInfo.Clear();
                            gridView2.SortInfo.Add(new GridColumnSortInfo(gridView1.Columns["LocItemID"], DevExpress.Data.ColumnSortOrder.Descending));

                            // اطمینان حاصل کنید که GridView داده‌ها دارد
                            if (gridView2.RowCount > 0)
                            {
                                // تنظیم نشانگر به اولین ردیف
                                gridView2.FocusedRowHandle = 0;
                            }
                            _isAllSelected = false;
                            btnSelectAll.Text = "Select All";
                            // _isAllHoldSelected = false;
                        }
                    }
                }
            }
        }

        private bool updatingQtyInLoc = false;

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "LocationID" && e.RowHandle >= 0)
            {
                object newLocationValue = e.Value;
                int[] selectedRows = view.GetSelectedRows();

                view.CellValueChanged -= gridView2_CellValueChanged;

                List<UpdateLocitemLocationDto> updateDtos = new List<UpdateLocitemLocationDto>();

                foreach (int rowHandle in selectedRows)
                {
                    view.SetRowCellValue(rowHandle, "LocationID", newLocationValue);

                    object locItemId = gridView2.GetRowCellValue(rowHandle, "LocItemID");

                    if (locItemId != null)
                    {
                        int locItemIdValue = Convert.ToInt32(locItemId);
                        int locationIdValue = Convert.ToInt32(newLocationValue);

                        var updateDto = new UpdateLocitemLocationDto
                        {
                            LocItemID = locItemIdValue,
                            LocationID = locationIdValue,
                            EditedBy = _session.UserID, // Replace with the actual current user
                            EditedDate = DateTime.Now
                        };

                        updateDtos.Add(updateDto);
                    }
                    else
                    {
                        XtraMessageBox.Show($"LocItemID is null for row handle {rowHandle}.");
                    }
                }

                view.CellValueChanged += gridView2_CellValueChanged;

                UpdateLocationsInDatabase(updateDtos);
            }
            if (!updatingQtyInLoc && (e.Column.FieldName == "OverQty" || e.Column.FieldName == "ShortageQty" || e.Column.FieldName == "Qty"))
            {
                try
                {
                    updatingQtyInLoc = true;
                    UpdateQtyinloc(e);
                }
                finally
                {
                    updatingQtyInLoc = false;
                }
            }
            if (e.Column.FieldName != "StorageCode")
            {
                object LocItemObj = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LocItemID");
                object ItemIdObj = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ItemId");
                object PKIDObj = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "PKID");
                UpdateDatabase(Convert.ToInt32(LocItemObj), Convert.ToInt32(ItemIdObj), Convert.ToInt32(PKIDObj));
            }
        }

        private async void UpdateLocationsInDatabase(List<UpdateLocitemLocationDto> updateDtos)
        {
            try
            {
                await _LocitemRepository.UpdateLocationsAsync(updateDtos);
                gridView2.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private async void UpdateDatabase(int locitem, int itemid, int PKID)
        {
            int entityId = locitem;
            int itemId = itemid;
            int pkId = PKID;
            int focusedRowHandle = gridView2.FocusedRowHandle;

            try
            {
                // گرفتن شی از متدل
                var entityToUpdate = await _LocitemRepository.GetByIdAsync(entityId);

                // بررسی وجود شی
                if (entityToUpdate != null)
                {
                    // به‌روزرسانی ویژگی‌های شی با مقادیر تغییر یافته
                    entityToUpdate.OverQty = GetCellValue<decimal>(focusedRowHandle, "OverQty", gridView2);
                    entityToUpdate.ShortageQty = GetCellValue<decimal>(focusedRowHandle, "ShortageQty", gridView2);
                    entityToUpdate.Qty = GetCellValue<decimal>(focusedRowHandle, "Qty", gridView2);
                    entityToUpdate.DamageQty = GetCellValue<decimal>(focusedRowHandle, "DamageQty", gridView2);
                    entityToUpdate.RejectQty = GetCellValue<decimal>(focusedRowHandle, "RejectQty", gridView2);
                    entityToUpdate.NISQty = GetCellValue<decimal>(focusedRowHandle, "NISQty", gridView2);
                    entityToUpdate.LocationID = GetCellValue<int>(focusedRowHandle, "LocationID", gridView2);

                    // به‌روزرسانی ویژگی‌های ویرایش
                    entityToUpdate.EditedBy = _session.UserID; // فرض می‌کنیم متغیری به نام currentUser دارید که کاربر جاری را نگه می‌دارد
                    entityToUpdate.EditedDate = DateTime.Now;

                    // فراخوانی متد به‌روزرسانی برای ذخیره تغییرات
                    await _LocitemRepository.UpdateAsync(entityToUpdate);
                }
                else
                {
                    XtraMessageBox.Show("Warning!!! Entity (LocItem) not found. A problem has occurred.");
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details for debugging
                XtraMessageBox.Show($"Error occurred: {ex.Message}" + "LocItem Section");
            }

            try
            {
                // گرفتن شی از متدل
                var entityItemToUpdate = await _itemRepository.GetByIdAsync(itemid);

                // بررسی وجود شی
                if (entityItemToUpdate != null)
                {
                    // به‌روزرسانی ویژگی‌های شی با مقادیر تغییر یافته
                    entityItemToUpdate.ItemOfPk = GetCellValue<int?>(focusedRowHandle, "ItemOfPk", gridView2).GetValueOrDefault(0);
                    entityItemToUpdate.PKID = GetCellValue<int?>(focusedRowHandle, "PKID", gridView2).GetValueOrDefault(0);
                    entityItemToUpdate.NetW = GetCellValue<decimal?>(focusedRowHandle, "NetW", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.GrossW = GetCellValue<decimal?>(focusedRowHandle, "GrossW", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.IncorectQty = GetCellValue<decimal?>(focusedRowHandle, "IncorectQty", gridView2).GetValueOrDefault(0.00m);

                    entityItemToUpdate.Tag = GetCellValue<string>(focusedRowHandle, "Tag", gridView2) ?? string.Empty;
                    entityItemToUpdate.Description = GetCellValue<string>(focusedRowHandle, "Description", gridView2) ?? string.Empty;
                    entityItemToUpdate.UnitID = GetCellValue<int?>(focusedRowHandle, "UnitID", gridView2).GetValueOrDefault(1);
                    entityItemToUpdate.Qty = GetCellValue<decimal?>(focusedRowHandle, "QtyPL", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.OverQty = GetCellValue<decimal?>(focusedRowHandle, "OverQtyPL", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.ShortageQty = GetCellValue<decimal?>(focusedRowHandle, "ShortageQtyPL", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.DamageQty = GetCellValue<decimal?>(focusedRowHandle, "DamageQtyPL", gridView2).GetValueOrDefault(0.00m);
                    entityItemToUpdate.ScopeID = GetCellValue<int?>(focusedRowHandle, "ScopeID", gridView2).GetValueOrDefault(1);
                    entityItemToUpdate.HeatNo = GetCellValue<string>(focusedRowHandle, "HeatNo", gridView2) ?? string.Empty;
                    entityItemToUpdate.BatchNo = GetCellValue<string>(focusedRowHandle, "BatchNo", gridView2) ?? string.Empty;
                    entityItemToUpdate.Remark = GetCellValue<string>(focusedRowHandle, "Remark", gridView2) ?? string.Empty;
                    entityItemToUpdate.NIS = GetCellValue<decimal?>(focusedRowHandle, "NIS", gridView2).GetValueOrDefault(0.00m);
                    //entityItemToUpdate.Hold = GetCellValue<bool?>(focusedRowHandle, "Hold", gridView2);
                    //var holdValue = GetCellValue<bool?>(focusedRowHandle, "Hold", gridView2);
                    //entityItemToUpdate.Hold = holdValue.HasValue ? holdValue.Value : (bool?)null;
                    entityItemToUpdate.Hold = gridView2.GetRowCellValue(focusedRowHandle, "Hold") as bool? ?? false;


                    // به‌روزرسانی ویژگی‌های ویرایش
                    entityItemToUpdate.EditedBy = _session.UserID; // فرض می‌کنیم متغیری به نام currentUser دارید که کاربر جاری را نگه می‌دارد
                    entityItemToUpdate.EditedDate = DateTime.Now;

                    // فراخوانی متد به‌روزرسانی برای ذخیره تغییرات
                    await _itemRepository.UpdateAsync(entityItemToUpdate);
                }
                else
                {
                    XtraMessageBox.Show("Warning!!! Entity (ItemId) not found. A problem has occurred.");
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details for debugging
                XtraMessageBox.Show($"Error occurred: {ex.Message}" + "ITEM Section");
                // در اینجا می‌توانید خطاها را لاگ کنید
                // Logger.LogError(ex, "An error occurred while updating the entity.");
            }

            try
            {
                // گرفتن شی از متدل
                var entityToUpdate = _packageRepository.GetPackageById(pkId);

                // بررسی وجود شی
                if (entityToUpdate != null)
                {
                    // به‌روزرسانی ویژگی‌های شی با مقادیر تغییر یافته
                    entityToUpdate.ArrivalDate = GetCellValue<DateTime?>(focusedRowHandle, "ArrivalDate", gridView2);
                    entityToUpdate.MSRNO = GetCellValue<string>(focusedRowHandle, "MSRNO", gridView2);
                    entityToUpdate.MSRPDF = GetCellValue<string>(focusedRowHandle, "MSRPDF", gridView2);

                    // به‌روزرسانی ویژگی‌های ویرایش
                    entityToUpdate.EditedBy = _session.UserID; // فرض می‌کنیم متغیری به نام currentUser دارید که کاربر جاری را نگه می‌دارد
                    entityToUpdate.EditedDate = DateTime.Now;

                    // ساخت DTO برای به‌روزرسانی
                    var updatedPackage = new UpdatePackageDto
                    {
                        PKID = entityToUpdate.PKID,
                        ArrivalDate = entityToUpdate.ArrivalDate,
                        MSRNO = entityToUpdate.MSRNO,
                        MSRPDF = entityToUpdate.MSRPDF,
                        EditedBy = entityToUpdate.EditedBy,
                        EditedDate = entityToUpdate.EditedDate
                    };

                    // فراخوانی متد به‌روزرسانی برای ذخیره تغییرات
                    var updateResult = _packageRepository.UpdatePackage(pkId, updatedPackage);

                    if (!updateResult)
                    {
                        XtraMessageBox.Show("Warning!!! Update failed. A problem has occurred.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Warning!!! Entity (PKID) not found. A problem has occurred.");
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details for debugging
                XtraMessageBox.Show($"Error occurred: {ex.Message}" + "PK Section");
            }
        }

        private T GetCellValue<T>(int focusedRowHandle, string columnName, GridView gridView)
        {
            object value = gridView.GetRowCellValue(focusedRowHandle, columnName);

            if (value == DBNull.Value)
            {
                return default(T);
            }

            try
            {
                if (typeof(T) == typeof(decimal?))
                {
                    return (T)(object)(value is decimal decimalValue ? (decimal?)decimalValue : null);
                }
                if (typeof(T) == typeof(decimal))
                {
                    return (T)(object)(value is decimal decimalValue ? decimalValue : 0m);
                }
                if (typeof(T) == typeof(int?))
                {
                    return (T)(object)(value is int intValue ? (int?)intValue : null);
                }
                if (typeof(T) == typeof(int))
                {
                    return (T)(object)(value is int intValue ? intValue : 0);
                }
                if (typeof(T) == typeof(string))
                {
                    return (T)value;
                }

                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (InvalidCastException)
            {
                // برای رفع خطا، می‌توانید پیغام خطا ثبت کنید یا مقدار پیش‌فرض برگردانید
                return default(T);
            }
        }


        private void UpdateQtyinloc(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int focusedRowHandle = gridView2.FocusedRowHandle;

            if (focusedRowHandle >= 0 && focusedRowHandle < gridView2.DataRowCount)
            {
                object overQtyObj = gridView2.GetRowCellValue(focusedRowHandle, "OverQty");
                object overObj = gridView2.GetRowCellValue(focusedRowHandle, "OverQty");
                object shortageQtyObj = gridView2.GetRowCellValue(focusedRowHandle, "ShortageQty");
                object shortageObj = gridView2.GetRowCellValue(focusedRowHandle, "ShortageQty");
                object qtyInLocObj = gridView2.GetRowCellValue(focusedRowHandle, "Qty");

                int newoverQty = overQtyObj != DBNull.Value && overQtyObj != null ? Convert.ToInt32(overQtyObj) : 0;
                int overQty = overQtyObj != DBNull.Value && overQtyObj != null ? Convert.ToInt32(overObj) : 0;
                int newshortageQty = shortageQtyObj != DBNull.Value && shortageQtyObj != null ? Convert.ToInt32(shortageQtyObj) : 0;
                int shortageQty = shortageQtyObj != DBNull.Value && shortageQtyObj != null ? Convert.ToInt32(shortageObj) : 0;
                int newqtyInLoc = qtyInLocObj != DBNull.Value && qtyInLocObj != null ? Convert.ToInt32(qtyInLocObj) : 0;


                int oldoverQty = e.OldValue != DBNull.Value && e.OldValue != null ? Convert.ToInt32(e.OldValue) : 0;
                int oldshortageQty = e.OldValue != DBNull.Value && e.OldValue != null ? Convert.ToInt32(e.OldValue) : 0;
                int newQty = 0;
                if (e.Column.FieldName == "Qty")
                {
                    // User directly changed "Qtyinloc"
                    newQty = (newqtyInLoc + newoverQty) - newshortageQty;
                    //MessageBox.Show("direct change: " + newQty);
                }
                else if (e.Column.FieldName == "OverQty" && newoverQty - oldoverQty != 0)
                {
                    newQty = (newqtyInLoc - oldoverQty) + newoverQty;
                    //MessageBox.Show("over : " + newQty);
                    newqtyInLoc = newQty;
                }
                else if (e.Column.FieldName == "ShortageQty" && newshortageQty - oldshortageQty != 0)
                {
                    newQty = (newqtyInLoc + oldshortageQty) - newshortageQty;
                    //MessageBox.Show("shortage : " + newQty);
                    newqtyInLoc = newQty;
                }

                gridView2.SetRowCellValue(focusedRowHandle, "Qty", newQty);

                if (newoverQty != overQty)
                {
                    MessageBox.Show("Check the Over Qty: OverQtyloc is different from OverQty");
                }
                if (newshortageQty != shortageQty)
                {
                    MessageBox.Show("Check the Shortage Qty: ShortageQtyloc is different from ShortageQty");
                }
            }
        }

        private async void simpleButton7_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = await _packingRepository.AllItemSelectedPlAsync(PLid);
            repositoryItemLookUpEditpk.DataSource = _packageRepository.GetPackageByPLId(PLid);
            _isAllSelected = false;
            btnSelectAll.Text = "Select All";
            XtraMessageBox.Show("All Data Refreshed ;)", "Success Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
            simpleButton7_Click(null, null);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            btnRefreshArchiveNO_Click(null, null);
        }

        private async void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBoxEdit = sender as ComboBoxEdit;
            GridView view = gridView2; // Set to your GridView

            if (comboBoxEdit != null && view != null)
            {
                // Get the new storage value
                string newStorageValue = comboBoxEdit.EditValue?.ToString();

                if (!string.IsNullOrEmpty(newStorageValue))
                {
                    // Get all item IDs from selected rows
                    int[] selectedRows = view.GetSelectedRows();
                    List<int> itemIds = new List<int>();

                    foreach (int rowHandle in selectedRows)
                    {
                        object itemIdObj = view.GetRowCellValue(rowHandle, "ItemId");
                        if (itemIdObj != null && int.TryParse(itemIdObj.ToString(), out int itemId))
                        {
                            itemIds.Add(itemId);
                        }
                    }

                    // Apply the new storage value to all selected rows
                    if (itemIds.Count > 0)
                    {
                        try
                        {
                            await _itemRepository.UpdateStorageCodesAsync(itemIds, newStorageValue);

                            // Update the grid view
                            view.BeginDataUpdate();
                            try
                            {
                                foreach (int rowHandle in selectedRows)
                                {
                                    view.SetRowCellValue(rowHandle, "StorageCode", newStorageValue);
                                }
                            }
                            finally
                            {
                                view.EndDataUpdate();
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show($"An error occurred while updating storage codes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            gridView2.BeginUpdate();
            try
            {
                if (_isAllSelected)
                {
                    // لغو انتخاب همه ردیف‌ها
                    gridView2.ClearSelection();
                    // تغییر متن دکمه به "Select All"
                    btnSelectAll.Text = "Select All";
                }
                else
                {
                    // انتخاب همه ردیف‌ها
                    gridView2.SelectAll();
                    // تغییر متن دکمه به "Unselect All"
                    btnSelectAll.Text = "Unselect All";
                }
                // به‌روزرسانی وضعیت انتخاب
                _isAllSelected = !_isAllSelected;
            }
            finally
            {
                gridView2.EndUpdate();
            }
        }

        private void btnHoldAll_Click(object sender, EventArgs e)
        {
            //    gridView2.BeginUpdate();
            //    try
            //    {
            //        if (_isAllHoldSelected)
            //        {
            //            // لغو انتخاب همه ردیف‌ها
            //            for (int i = 0; i < gridView2.RowCount; i++)
            //            {
            //                gridView2.SetRowCellValue(i, "Hold", false);
            //            }
            //            // تغییر متن دکمه به "Select All"
            //            btnHoldAll.Text = "Hold All";
            //        }
            //        else
            //        {
            //            // انتخاب همه ردیف‌ها
            //            for (int i = 0; i < gridView2.RowCount; i++)
            //            {
            //                gridView2.SetRowCellValue(i, "Hold", true);
            //            }
            //            // تغییر متن دکمه به "Unselect All"
            //            btnHoldAll.Text = "UnHold All";
            //        }
            //        // به‌روزرسانی وضعیت انتخاب
            //        _isAllHoldSelected = !_isAllSelected;
            //    }
            //    finally
            //    {
            //        gridView2.EndUpdate();
            //    }

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "ViewPackingExcelOutPut.xlsx" })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        ExportFromGridViewDevexpress.ExportToExcel(gridView2, sfd.FileName); // فرض می‌کنیم gridView1 نام GridView DevExpress شماست
            //    }
            //}


            ExportFromGridViewDevexpress.SaveGridData("Excel Files|*.xlsx", "Save Excel File", fileName => gridView2.ExportToXlsx(fileName));
        
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            gridView2.OptionsBehavior.ReadOnly = !checkEdit3.Checked;
            //if (checkEdit2.Checked) { gridView1.OptionsBehavior.ReadOnly = false; } else { gridView1.OptionsBehavior.ReadOnly = true; }

        }
    }
}










