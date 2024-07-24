using AWMS.dapper.Repositories;
using AWMS.dto;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AWMS.dapper
{
    public class LocItemDapperRepository : ILocItemDapperRepository
    {
        private readonly string _connectionString;

        public LocItemDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task AddAsync(LocItemDto locItem)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LocationID", locItem.LocationID);
                parameters.Add("@ItemId", locItem.ItemId);
                parameters.Add("@Qty", locItem.Qty);
                parameters.Add("@OverQty", locItem.OverQty);
                parameters.Add("@ShortageQty", locItem.ShortageQty);
                parameters.Add("@DamageQty", locItem.DamageQty);
                parameters.Add("@RejectQty", locItem.RejectQty);
                parameters.Add("@NISQty", locItem.NISQty);
                parameters.Add("@EnteredBy", locItem.EnteredBy);
                parameters.Add("@EnteredDate", locItem.EnteredDate);

                await connection.ExecuteAsync("AddLocItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int locItemId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LocItemID", locItemId);

                await connection.ExecuteAsync("DeleteLocItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteMultipleLocItemsWithTransactionAsync(IEnumerable<LocItemDto> locItems)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var table = new DataTable();
                        table.Columns.Add("LocItemID", typeof(int));

                        foreach (var item in locItems)
                        {
                            table.Rows.Add(item.LocItemID);
                        }

                        var parameters = new DynamicParameters();
                        parameters.Add("@LocItemIDList", table.AsTableValuedParameter("dbo.LocItemIDListType"));

                        await connection.ExecuteAsync("DeleteMultipleLocItems", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<LocItemDto>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<LocItemDto>("GetAllLocItems", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<LocItemDto> GetByIdAsync(int locItemId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LocItemID", locItemId);

                return await connection.QuerySingleOrDefaultAsync<LocItemDto>("GetLocItemById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task UpdateAsync(LocItemDto locItem)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LocItemID", locItem.LocItemID);
                parameters.Add("@LocationID", locItem.LocationID);
                parameters.Add("@ItemId", locItem.ItemId);
                parameters.Add("@Qty", locItem.Qty);
                parameters.Add("@OverQty", locItem.OverQty);
                parameters.Add("@ShortageQty", locItem.ShortageQty);
                parameters.Add("@DamageQty", locItem.DamageQty);
                parameters.Add("@RejectQty", locItem.RejectQty);
                parameters.Add("@NISQty", locItem.NISQty);
                parameters.Add("@EditedBy", locItem.EditedBy);
                parameters.Add("@EditedDate", locItem.EditedDate);

                await connection.ExecuteAsync("UpdateLocItem", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> IsLocationUsedAsync(int locationID, int itemId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@LocationID", locationID);
                parameters.Add("@ItemId", itemId);

                var result = await connection.QuerySingleAsync<int>(
                    "dbo.IsLocationUsedByItem",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result == 1;
            }
        }
        public async Task<IEnumerable<LocItemDto>> GetLocItemsByItemIdAsync(int itemId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ItemId", itemId);

                var locItems = await connection.QueryAsync<LocItemDto>(
                    "dbo.GetLocItemsByItemId",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return locItems;
            }
        }


    }
}
