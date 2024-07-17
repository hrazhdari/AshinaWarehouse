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
    public class UnitDapperRepository : IUnitDapperRepository
    {
        private readonly string _connectionString;
        public UnitDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task AddAsync(UnitDto unit)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("UnitName", unit.UnitName);
                await connection.ExecuteAsync("spInsertUnit", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("UnitID", id);
                await connection.ExecuteAsync("spDeleteUnit", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<UnitDto>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<UnitDto>("spGetAllUnits", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<UnitDto> GetByIdAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("UnitID", id);
                return await connection.QueryFirstOrDefaultAsync<UnitDto>("spGetUnitById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task UpdateAsync(UnitDto unit)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("UnitID", unit.UnitID);
                parameters.Add("UnitName", unit.UnitName);
                await connection.ExecuteAsync("spUpdateUnit", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
