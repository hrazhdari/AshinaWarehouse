using Dapper;
using AWMS.dto;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AWMS.dapper.Repositories;

namespace AWMS.dapper
{
    public class PackingListDapperRepository : IPackingListDapperRepository
    {
        private readonly string _connectionString;

        public PackingListDapperRepository(IConfiguration configuration)
        {
            //با استفاده از ! عملگر null-forgiving، که به کامپایلر می گوید که _connectionString قطعاً تا زمانی که از آن استفاده می شود مقداردهی اولیه می شود.
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public async Task<IEnumerable<PackingListDto>> GetAllAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<PackingListDto>("GetAllPackingLists", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<PackingListDto> GetByIdAsync(int PlId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var result = await db.QueryFirstOrDefaultAsync<PackingListDto>(
                    "GetPackingListById", new { PlId }, commandType: CommandType.StoredProcedure);

                if (result == null)
                {
                    throw new KeyNotFoundException($"PackingList with Id {PlId} not found.");
                }

                return result;
            }
        }

        public async Task<bool> AddAsync(PackingListDto packingListDto)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    var result = await db.ExecuteAsync(
                        "AddPackingList",
                        new
                        {
                            packingListDto.ShId,
                            packingListDto.MrId,
                            packingListDto.PoId,
                            packingListDto.IrnId,
                            packingListDto.PLName,
                            packingListDto.ArchiveNO,
                            packingListDto.PLNO,
                            packingListDto.OPINO,
                            packingListDto.Project,
                            packingListDto.AreaUnitID,
                            packingListDto.SupplierId,
                            packingListDto.DesciplineId,
                            packingListDto.VendorId,
                            packingListDto.DescriptionForPkId,
                            packingListDto.NetW,
                            packingListDto.GrossW,
                            packingListDto.Volume,
                            packingListDto.Vessel,
                            packingListDto.EnteredBy,
                            packingListDto.EnteredDate,
                            packingListDto.MARDate,
                            packingListDto.Remark,
                            packingListDto.LocalForeign,
                            packingListDto.RTINO,
                            packingListDto.InvoiceNO,
                            packingListDto.IRCNO,
                            packingListDto.LCNO,
                            packingListDto.BLNO,
                            packingListDto.Remarkcustoms,
                            packingListDto.EditedBy,
                            packingListDto.EditedDate,
                            packingListDto.PLDPF,
                            packingListDto.Balance,
                            packingListDto.Attachment,
                            packingListDto.SitePL
                        },
                        commandType: CommandType.StoredProcedure);

                    return result > 0;
                }
            }
            catch
            {
                return false;
            }
        }


        public async Task UpdateAsync(PackingListDto packingListDto)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                await db.ExecuteAsync(
                    "UpdatePackingList",
                    new
                    {
                        packingListDto.PLId,
                        packingListDto.ShId,
                        packingListDto.MrId,
                        packingListDto.PoId,
                        packingListDto.IrnId,
                        packingListDto.PLName,
                        packingListDto.ArchiveNO,
                        packingListDto.PLNO,
                        packingListDto.OPINO,
                        packingListDto.Project,
                        packingListDto.AreaUnitID,
                        packingListDto.SupplierId,
                        packingListDto.DesciplineId,
                        packingListDto.VendorId,
                        packingListDto.DescriptionForPkId,
                        packingListDto.NetW,
                        packingListDto.GrossW,
                        packingListDto.Volume,
                        packingListDto.Vessel,
                        packingListDto.EnteredBy,
                        packingListDto.EnteredDate,
                        packingListDto.MARDate,
                        packingListDto.Remark,
                        packingListDto.LocalForeign,
                        packingListDto.RTINO,
                        packingListDto.InvoiceNO,
                        packingListDto.IRCNO,
                        packingListDto.LCNO,
                        packingListDto.BLNO,
                        packingListDto.Remarkcustoms,
                        packingListDto.EditedBy,
                        packingListDto.EditedDate,
                        packingListDto.PLDPF,
                        packingListDto.Balance,
                        packingListDto.Attachment,
                        packingListDto.SitePL
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int PlId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                await db.ExecuteAsync("DeletePackingList", new { PlId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<PackingListDto> GetByPlNameAsync(string PlName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var result= await db.QueryFirstOrDefaultAsync<PackingListDto>(
                    "GetPackingListByPlName", new { PlName }, commandType: CommandType.StoredProcedure);
                if (result == null)
                {
                    throw new KeyNotFoundException($"PackingList with Id {PlName} not found.");
                }
                return result;
            }
        }

        public async Task<bool> ExistsByPlNameAsync(string plName)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.ExecuteScalarAsync<bool>(
                    "ExistsPackingListByPlName", new { PlName = plName }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> ExistsByPlNoAsync(string PlNo)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.ExecuteScalarAsync<bool>(
                    "ExistsPackingListByPlNo", new { PlNo = PlNo }, commandType: CommandType.StoredProcedure);
            }
        }

        public string LastArchiveNo()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                try
                {
                    var sql = "GetLastArchiveNo";
                    var parameters = new DynamicParameters();
                    var command = new CommandDefinition(
                        sql,
                        parameters,
                        commandType: CommandType.StoredProcedure,
                        commandTimeout: 60 // تنظیم CommandTimeout به 60 ثانیه
                    );

                    var result = db.QuerySingleOrDefault<string>(command);

                    return result ?? "0"; // اگر نتیجه null بود، "0" برگردانده می‌شود.
                }
                catch
                {
                    return "0"; // در صورت بروز هرگونه ایراد، "0" برگردانده می‌شود.
                }
            }
        }


        public bool ExistsByOpiNumber(string OpiNumber)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var result = db.ExecuteScalar<int>(
                    "ExistsPackingListByOpiNumber", new { OpiNumber }, commandType: CommandType.StoredProcedure);
                return result == 1;
            }
        }

        public async Task<IEnumerable<PackingListAllPlNameDto>> GetAllPlNameAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<PackingListAllPlNameDto>("GetAllPackingListsNames", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
