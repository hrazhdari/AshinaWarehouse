using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using AWMS.dto;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;
using AWMS.dapper.Repositories;

namespace AWMS.dapper
{
    public class PackageDapperRepository : IPackageDapperRepository
    {
        private readonly string _connectionString;
        public PackageDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public bool AddPackage(PackageDto package)
        {
            if (package == null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", package.PLId);
                parameters.Add("@PK", package.PK);
                parameters.Add("@NetW", package.NetW);
                parameters.Add("@GrossW", package.GrossW);
                parameters.Add("@Dimension", package.Dimension);
                parameters.Add("@Volume", package.Volume);
                parameters.Add("@ArrivalDate", package.ArrivalDate);
                parameters.Add("@Desciption", package.Desciption);
                parameters.Add("@Remark", package.Remark);
                parameters.Add("@EnteredBy", package.EnteredBy);
                parameters.Add("@EnteredDate", package.EnteredDate);
                parameters.Add("@EditedBy", package.EditedBy);
                parameters.Add("@EditedDate", package.EditedDate);
                parameters.Add("@MSRNO", package.MSRNO);
                parameters.Add("@MSRPDF", package.MSRPDF);
                parameters.Add("@MSRDate", package.MSRDate);
                parameters.Add("@MSREnteredBy", package.MSREnteredBy);
                parameters.Add("@MSRStatus", package.MSRStatus);
                parameters.Add("@MSRRev", package.MSRRev);
                parameters.Add("@MSRRevEnteredBy", package.MSRRevEnteredBy);
                parameters.Add("@MSRRevDate", package.MSRRevDate);

                var affectedRows = connection.Execute("AddPackage", parameters, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public bool DeletePackage(int packageId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PackageId", packageId);

                var affectedRows = connection.Execute("DeletePackage", parameters, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public IEnumerable<PackageDto> GetAllPackage()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<PackageDto>("GetAllPackages", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<PackageDto>> GetAllPackageAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<PackageDto>("GetAllPackages", commandType: CommandType.StoredProcedure);
            }
        }

        public PackageDto GetPackageById(int packageId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PackageId", packageId);

                return connection.QueryFirstOrDefault<PackageDto>("GetPackageById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<PackageDto> GetPackageByPLId(int plId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId);

                return connection.Query<PackageDto>("GetPackagesByPLId", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public PackageDto GetPackageByPK(int pk)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PK", pk);

                return connection.QueryFirstOrDefault<PackageDto>("GetPackageByPK", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool GetPackageByPackageNameBool(string packageName)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PackageName", packageName);

                return connection.ExecuteScalar<bool>("CheckPackageByName", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetLastPackage(int plId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId);

                return connection.ExecuteScalar<int>("GetLastPackage", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetPackageCount(int plId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId);

                return connection.ExecuteScalar<int>("GetPackageCount", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool CheckPkExist(int plId, int pkNumber)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId);
                parameters.Add("@PK", pkNumber);

                return connection.ExecuteScalar<bool>("CheckPackageExistence", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetPkId(int plId, int pkNumber)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PLId", plId);
                parameters.Add("@PK", pkNumber);

                return connection.ExecuteScalar<int>("GetPackageId", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int? GetPackageByPKID(int packageId)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PackageId", packageId);

                return connection.ExecuteScalar<int?>("GetPackagePKByPKID", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool UpdatePackage(int packageId, PackageDto updatedPackage)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PKID", packageId);
                parameters.Add("@PLId", updatedPackage.PLId);
                parameters.Add("@PK", updatedPackage.PK);
                parameters.Add("@NetW", updatedPackage.NetW);
                parameters.Add("@GrossW", updatedPackage.GrossW);
                parameters.Add("@Dimension", updatedPackage.Dimension);
                parameters.Add("@Volume", updatedPackage.Volume);
                parameters.Add("@ArrivalDate", updatedPackage.ArrivalDate);
                parameters.Add("@Desciption", updatedPackage.Desciption);
                parameters.Add("@Remark", updatedPackage.Remark);
                parameters.Add("@EnteredBy", updatedPackage.EnteredBy);
                parameters.Add("@EnteredDate", updatedPackage.EnteredDate);
                parameters.Add("@EditedBy", updatedPackage.EditedBy);
                parameters.Add("@EditedDate", updatedPackage.EditedDate);
                parameters.Add("@MSRNO", updatedPackage.MSRNO);
                parameters.Add("@MSRPDF", updatedPackage.MSRPDF);
                parameters.Add("@MSRDate", updatedPackage.MSRDate);
                parameters.Add("@MSREnteredBy", updatedPackage.MSREnteredBy);
                parameters.Add("@MSRStatus", updatedPackage.MSRStatus);
                parameters.Add("@MSRRev", updatedPackage.MSRRev);
                parameters.Add("@MSRRevEnteredBy", updatedPackage.MSRRevEnteredBy);
                parameters.Add("@MSRRevDate", updatedPackage.MSRRevDate);

                var affectedRows = connection.Execute("UpdatePackage", parameters, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public async Task DeleteMultiplePKsWithTransactionAsync(IEnumerable<PackagePKIDDto> PKIDs)
        {
            using (var connection = CreateConnection())
            {
                 connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var table = new DataTable();
                        table.Columns.Add("PKID", typeof(int));

                        foreach (var PKID in PKIDs)
                        {
                            table.Rows.Add(PKID.PKID);
                        }

                        var parameters = new DynamicParameters();
                        parameters.Add("@PKIDList", table.AsTableValuedParameter("dbo.PackagePKIDDtoType"));

                        await connection.ExecuteAsync("DeletePackages", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);

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
