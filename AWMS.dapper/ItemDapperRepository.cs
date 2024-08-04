using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using AWMS.dto;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AWMS.dapper.Repositories;

namespace AWMS.dapper
{
    public class ItemDapperRepository : IItemDapperRepository
    {
        private readonly string _connectionString;

        public ItemDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }
        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
        //public async Task AddItemWithLocitemAsync(ItemDto itemDto,int LocationId)
        //{
        //    using (var connection = CreateConnection())
        //    {
        //        using (var transaction = connection.BeginTransaction())
        //        {
        //            try
        //            {
        //                // Adding Item
        //                var itemParameters = new DynamicParameters();
        //                itemParameters.Add("@PKID", itemDto.PKID);
        //                itemParameters.Add("@ItemOfPk", itemDto.ItemOfPk);
        //                itemParameters.Add("@Tag", itemDto.Tag);
        //                itemParameters.Add("@Description", itemDto.Description);
        //                itemParameters.Add("@UnitID", itemDto.UnitID);
        //                itemParameters.Add("@Qty", itemDto.Qty);
        //                itemParameters.Add("@OverQty", itemDto.OverQty);
        //                itemParameters.Add("@ShortageQty", itemDto.ShortageQty);
        //                itemParameters.Add("@DamageQty", itemDto.DamageQty);
        //                itemParameters.Add("@IncorectQty", itemDto.IncorectQty);
        //                itemParameters.Add("@ScopeID", itemDto.ScopeID);
        //                itemParameters.Add("@HeatNo", itemDto.HeatNo);
        //                itemParameters.Add("@BatchNo", itemDto.BatchNo);
        //                itemParameters.Add("@Remark", itemDto.Remark);
        //                itemParameters.Add("@MTRNo", itemDto.MTRNo);
        //                itemParameters.Add("@ColorCode", itemDto.ColorCode);
        //                itemParameters.Add("@LabelNo", itemDto.LabelNo);
        //                itemParameters.Add("@EnteredBy", itemDto.EnteredBy);
        //                itemParameters.Add("@EnteredDate", itemDto.EnteredDate);
        //                itemParameters.Add("@EditedBy", itemDto.EditedBy);
        //                itemParameters.Add("@EditedDate", itemDto.EditedDate);
        //                itemParameters.Add("@Price", itemDto.Price);
        //                itemParameters.Add("@UnitPriceID", itemDto.UnitPriceID);
        //                itemParameters.Add("@NetW", itemDto.NetW);
        //                itemParameters.Add("@GrossW", itemDto.GrossW);
        //                itemParameters.Add("@ItemCodeId", itemDto.ItemCodeId);
        //                itemParameters.Add("@BaseMaterial", itemDto.BaseMaterial);
        //                itemParameters.Add("@Hold", itemDto.Hold);
        //                itemParameters.Add("@NIS", itemDto.NIS);

        //                var itemId = await connection.ExecuteScalarAsync<int>(
        //                    "sp_AddItem",
        //                    itemParameters,
        //                    transaction: transaction,
        //                    commandType: CommandType.StoredProcedure);

        //                // Adding default location entry in LocItem
        //                var locItemParameters = new DynamicParameters();
        //                locItemParameters.Add("@ItemId", itemId);
        //                locItemParameters.Add("@LocationID", LocationId); // Assuming default location ID is 1
        //                locItemParameters.Add("@Qty", itemDto.Qty);
        //                locItemParameters.Add("@OverQty", 0);
        //                locItemParameters.Add("@ShortageQty", 0);
        //                locItemParameters.Add("@DamageQty", 0);
        //                locItemParameters.Add("@RejectQty", 0); // Default value for RejectQty
        //                locItemParameters.Add("@NISQty", 0); // Default value for NISQty
        //                locItemParameters.Add("@EnteredBy", itemDto.EnteredBy);
        //                locItemParameters.Add("@EnteredDate", itemDto.EnteredDate);
        //                locItemParameters.Add("@EditedBy", itemDto.EditedBy);
        //                locItemParameters.Add("@EditedDate", DateTime.Now);

        //                await connection.ExecuteAsync(
        //                    "INSERT INTO LocItem (ItemId, LocationID, Qty, OverQty, ShortageQty, DamageQty, RejectQty, NISQty, EnteredBy, EnteredDate, EditedBy, EditedDate) " +
        //                    "VALUES (@ItemId, @LocationID, @Qty, @OverQty, @ShortageQty, @DamageQty, @RejectQty, @NISQty, @EnteredBy, @EnteredDate, @EditedBy, @EditedDate)",
        //                    locItemParameters,
        //                    transaction: transaction);

        //                transaction.Commit();
        //            }
        //            catch (Exception)
        //            {
        //                transaction.Rollback();
        //                throw;
        //            }
        //        }
        //    }
        //}

        //public async Task AddItemWithAddLocitemWithTriggerAsync(ItemDto itemDto, int locationId)
        //{
        //    using (var connection = CreateConnection())
        //    {
        //        var parameters = new DynamicParameters();
        //        parameters.Add("@PKID", itemDto.PKID);
        //        parameters.Add("@ItemOfPk", itemDto.ItemOfPk);
        //        parameters.Add("@Tag", itemDto.Tag);
        //        parameters.Add("@Description", itemDto.Description);
        //        parameters.Add("@UnitID", itemDto.UnitID);
        //        parameters.Add("@Qty", itemDto.Qty);
        //        parameters.Add("@OverQty", itemDto.OverQty);
        //        parameters.Add("@ShortageQty", itemDto.ShortageQty);
        //        parameters.Add("@DamageQty", itemDto.DamageQty);
        //        parameters.Add("@IncorectQty", itemDto.IncorectQty);
        //        parameters.Add("@ScopeID", itemDto.ScopeID);
        //        parameters.Add("@HeatNo", itemDto.HeatNo);
        //        parameters.Add("@BatchNo", itemDto.BatchNo);
        //        parameters.Add("@Remark", itemDto.Remark);
        //        parameters.Add("@MTRNo", itemDto.MTRNo);
        //        parameters.Add("@ColorCode", itemDto.ColorCode);
        //        parameters.Add("@LabelNo", itemDto.LabelNo);
        //        parameters.Add("@EnteredBy", itemDto.EnteredBy);
        //        parameters.Add("@EnteredDate", itemDto.EnteredDate);
        //        parameters.Add("@EditedBy", itemDto.EditedBy);
        //        parameters.Add("@EditedDate", itemDto.EditedDate);
        //        parameters.Add("@Price", itemDto.Price);
        //        parameters.Add("@UnitPriceID", itemDto.UnitPriceID);
        //        parameters.Add("@NetW", itemDto.NetW);
        //        parameters.Add("@GrossW", itemDto.GrossW);
        //        parameters.Add("@ItemCodeId", itemDto.ItemCodeId);
        //        parameters.Add("@BaseMaterial", itemDto.BaseMaterial);
        //        parameters.Add("@Hold", itemDto.Hold);
        //        parameters.Add("@NIS", itemDto.NIS);
        //        parameters.Add("@LocationID", locationId); // New parameter

        //        await connection.ExecuteAsync("sp_AddItemWithAddLocitemWithTrigger", parameters, commandType: CommandType.StoredProcedure);
        //    }
        //}

        public async Task<int> AddItemWithAddLocitemWithTriggerAsync(ItemDto item, int locationId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("PKID", item.PKID);
                parameters.Add("ItemOfPk", item.ItemOfPk);
                parameters.Add("Tag", item.Tag);
                parameters.Add("Description", item.Description);
                parameters.Add("UnitID", item.UnitID);
                parameters.Add("Qty", item.Qty);
                parameters.Add("OverQty", item.OverQty);
                parameters.Add("ShortageQty", item.ShortageQty);
                parameters.Add("DamageQty", item.DamageQty);
                parameters.Add("IncorectQty", item.IncorectQty);
                parameters.Add("ScopeID", item.ScopeID);
                parameters.Add("HeatNo", item.HeatNo);
                parameters.Add("BatchNo", item.BatchNo);
                parameters.Add("Remark", item.Remark);
                parameters.Add("MTRNo", item.MTRNo);
                parameters.Add("ColorCode", item.ColorCode);
                parameters.Add("LabelNo", item.LabelNo);
                parameters.Add("EnteredBy", item.EnteredBy);
                parameters.Add("EnteredDate", item.EnteredDate);
                parameters.Add("EditedBy", item.EditedBy);
                parameters.Add("EditedDate", item.EditedDate);
                parameters.Add("Price", item.Price);
                parameters.Add("UnitPriceID", item.UnitPriceID);
                parameters.Add("NetW", item.NetW);
                parameters.Add("GrossW", item.GrossW);
                parameters.Add("ItemCodeId", item.ItemCodeId);
                parameters.Add("BaseMaterial", item.BaseMaterial);
                parameters.Add("Hold", item.Hold);
                parameters.Add("NIS", item.NIS);
                parameters.Add("LocationID", locationId);

                parameters.Add("NewItemId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                await connection.ExecuteAsync("sp_AddItemWithAddLocitemWithTrigger", parameters, commandType: CommandType.StoredProcedure);

                return parameters.Get<int>("NewItemId");
            }
        }

        public async Task AddAsync(ItemDto item)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PKID", item.PKID);
                parameters.Add("@ItemOfPk", item.ItemOfPk);
                parameters.Add("@Tag", item.Tag);
                parameters.Add("@Description", item.Description);
                parameters.Add("@UnitID", item.UnitID);
                parameters.Add("@Qty", item.Qty);
                parameters.Add("@OverQty", item.OverQty);
                parameters.Add("@ShortageQty", item.ShortageQty);
                parameters.Add("@DamageQty", item.DamageQty);
                parameters.Add("@IncorectQty", item.IncorectQty);
                parameters.Add("@ScopeID", item.ScopeID);
                parameters.Add("@HeatNo", item.HeatNo);
                parameters.Add("@BatchNo", item.BatchNo);
                parameters.Add("@Remark", item.Remark);
                parameters.Add("@MTRNo", item.MTRNo);
                parameters.Add("@ColorCode", item.ColorCode);
                parameters.Add("@LabelNo", item.LabelNo);
                parameters.Add("@EnteredBy", item.EnteredBy);
                parameters.Add("@EnteredDate", item.EnteredDate);
                parameters.Add("@EditedBy", item.EditedBy);
                parameters.Add("@EditedDate", item.EditedDate);
                parameters.Add("@Price", item.Price);
                parameters.Add("@UnitPriceID", item.UnitPriceID);
                parameters.Add("@NetW", item.NetW);
                parameters.Add("@GrossW", item.GrossW);
                parameters.Add("@ItemCodeId", item.ItemCodeId);
                parameters.Add("@BaseMaterial", item.BaseMaterial);
                parameters.Add("@Hold", item.Hold);
                parameters.Add("@NIS", item.NIS);

                await connection.ExecuteAsync("sp_AddItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ItemId", id);

                await connection.ExecuteAsync("sp_DeleteItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<ItemDto>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<ItemDto>("sp_GetAllItems", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<ItemDto>> GetAllItemByPlIdAsync(int PlId)
        {
            using (var connection = CreateConnection())
            {
                var items = await connection.QueryAsync<ItemDto>(
                    "sp_GetItemsByPlIdWithTempTable",
                    new { PlId },
                    commandType: CommandType.StoredProcedure);

                return items;
            }
        }

        public async Task<ItemDto> GetByIdAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ItemId", id);

                return await connection.QueryFirstOrDefaultAsync<ItemDto>("sp_GetItemById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task UpdateAsync(ItemDto item)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ItemId", item.ItemId);
                parameters.Add("@PKID", item.PKID);
                parameters.Add("@ItemOfPk", item.ItemOfPk);
                parameters.Add("@Tag", item.Tag);
                parameters.Add("@Description", item.Description);
                parameters.Add("@UnitID", item.UnitID);
                parameters.Add("@Qty", item.Qty);
                parameters.Add("@OverQty", item.OverQty);
                parameters.Add("@ShortageQty", item.ShortageQty);
                parameters.Add("@DamageQty", item.DamageQty);
                parameters.Add("@IncorectQty", item.IncorectQty);
                parameters.Add("@ScopeID", item.ScopeID);
                parameters.Add("@HeatNo", item.HeatNo);
                parameters.Add("@BatchNo", item.BatchNo);
                parameters.Add("@Remark", item.Remark);
                parameters.Add("@MTRNo", item.MTRNo);
                parameters.Add("@ColorCode", item.ColorCode);
                parameters.Add("@LabelNo", item.LabelNo);
                parameters.Add("@EnteredBy", item.EnteredBy);
                parameters.Add("@EnteredDate", item.EnteredDate);
                parameters.Add("@EditedBy", item.EditedBy);
                parameters.Add("@EditedDate", item.EditedDate);
                parameters.Add("@Price", item.Price);
                parameters.Add("@UnitPriceID", item.UnitPriceID);
                parameters.Add("@NetW", item.NetW);
                parameters.Add("@GrossW", item.GrossW);
                parameters.Add("@ItemCodeId", item.ItemCodeId);
                parameters.Add("@BaseMaterial", item.BaseMaterial);
                parameters.Add("@Hold", item.Hold);
                parameters.Add("@NIS", item.NIS);

                await connection.ExecuteAsync("sp_UpdateItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteMultipleItemsWithTransactionAsync(IEnumerable<ItemDto> items)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var table = new DataTable();
                        table.Columns.Add("ItemID", typeof(int));

                        foreach (var item in items)
                        {
                            table.Rows.Add(item.ItemId);
                        }

                        var parameters = new DynamicParameters();
                        parameters.Add("@ItemIDList", table.AsTableValuedParameter("dbo.ItemIDListType"));

                        await connection.ExecuteAsync("DeleteItems", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public async Task UpdateStorageCodesAsync(IEnumerable<int> itemIds, string newStorageCode)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var table = new DataTable();
                        table.Columns.Add("ItemID", typeof(int));

                        foreach (var itemId in itemIds)
                        {
                            table.Rows.Add(itemId);
                        }

                        var parameters = new DynamicParameters();
                        parameters.Add("@ItemIds", table.AsTableValuedParameter("dbo.ItemIDList"));
                        parameters.Add("@NewStorageCode", newStorageCode);

                        await connection.ExecuteAsync("UpdateStorageCodes", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


    }
}
