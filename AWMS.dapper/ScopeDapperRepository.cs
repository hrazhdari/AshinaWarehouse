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
    public class ScopeDapperRepository : IScopeDapperRepository
    {
        private readonly string _connectionString;
        public ScopeDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task AddAsync(ScopeDto scope)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("ScopeName", scope.ScopeName);
                await connection.ExecuteAsync("spInsertScope", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("ScopeID", id);
                await connection.ExecuteAsync("spDeleteScope", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<ScopeDto>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<ScopeDto>("spGetAllScopes", commandType: CommandType.StoredProcedure);
            }
        }
        public IEnumerable<ScopeDto> GetAll()
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<ScopeDto>("spGetAllScopes", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<ScopeDto> GetByIdAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("ScopeID", id);
                return await connection.QueryFirstOrDefaultAsync<ScopeDto>("spGetScopeById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task UpdateAsync(ScopeDto scope)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("ScopeID", scope.ScopeID);
                parameters.Add("ScopeName", scope.ScopeName);
                await connection.ExecuteAsync("spUpdateScope", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
