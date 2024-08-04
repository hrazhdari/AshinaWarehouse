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


        public async Task<(bool Success, string ErrorMessage)> UpdateAsync(PackingListDto packingListDto)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("PLId", packingListDto.PLId);
                parameters.Add("ShId", packingListDto.ShId);
                parameters.Add("MrId", packingListDto.MrId);
                parameters.Add("PoId", packingListDto.PoId);
                parameters.Add("IrnId", packingListDto.IrnId);
                parameters.Add("PLName", packingListDto.PLName);
                parameters.Add("ArchiveNO", packingListDto.ArchiveNO);
                parameters.Add("PLNO", packingListDto.PLNO);
                parameters.Add("OPINO", packingListDto.OPINO);
                parameters.Add("Project", packingListDto.Project);
                parameters.Add("AreaUnitID", packingListDto.AreaUnitID);
                parameters.Add("SupplierId", packingListDto.SupplierId);
                parameters.Add("DesciplineId", packingListDto.DesciplineId);
                parameters.Add("VendorId", packingListDto.VendorId);
                parameters.Add("DescriptionForPkId", packingListDto.DescriptionForPkId);
                parameters.Add("NetW", packingListDto.NetW);
                parameters.Add("GrossW", packingListDto.GrossW);
                parameters.Add("Volume", packingListDto.Volume);
                parameters.Add("Vessel", packingListDto.Vessel);
                parameters.Add("EnteredBy", packingListDto.EnteredBy);
                parameters.Add("EnteredDate", packingListDto.EnteredDate);
                parameters.Add("MARDate", packingListDto.MARDate);
                parameters.Add("Remark", packingListDto.Remark);
                parameters.Add("LocalForeign", packingListDto.LocalForeign);
                parameters.Add("RTINO", packingListDto.RTINO);
                parameters.Add("InvoiceNO", packingListDto.InvoiceNO);
                parameters.Add("IRCNO", packingListDto.IRCNO);
                parameters.Add("LCNO", packingListDto.LCNO);
                parameters.Add("BLNO", packingListDto.BLNO);
                parameters.Add("Remarkcustoms", packingListDto.Remarkcustoms);
                parameters.Add("EditedBy", packingListDto.EditedBy);
                parameters.Add("EditedDate", packingListDto.EditedDate);
                parameters.Add("PLDPF", packingListDto.PLDPF);
                parameters.Add("Balance", packingListDto.Balance);
                parameters.Add("Attachment", packingListDto.Attachment);
                parameters.Add("SitePL", packingListDto.SitePL);
                parameters.Add("Success", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                parameters.Add("ErrorMessage", dbType: DbType.String, size: 255, direction: ParameterDirection.Output);

                await db.ExecuteAsync("UpdatePackingList", parameters, commandType: CommandType.StoredProcedure);

                bool success = parameters.Get<bool>("Success");
                string errorMessage = parameters.Get<string>("ErrorMessage");

                return (success, errorMessage);
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

        public async Task<IEnumerable<AllItemSelectedPlDto>> AllItemSelectedPlAsync(int plId)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId, DbType.Int32);

                return await db.QueryAsync<AllItemSelectedPlDto>(
                    "AllItemSelectedPl",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task<IEnumerable<PackingListAllPlNameDto>> GetPackingListsWithoutPackagesAsync()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string storedProc = "GetPackingListsWithoutPackages";
                return await db.QueryAsync<PackingListAllPlNameDto>(storedProc, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
