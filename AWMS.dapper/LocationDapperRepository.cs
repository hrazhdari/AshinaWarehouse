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
    public class LocationDapperRepository : ILocationDapperRepository
    {
        private readonly string _connectionString;

        public LocationDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task AddAsync(LocationDto location)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("LocationName", location.LocationName);
                await connection.ExecuteAsync("spInsertLocation", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("LocationID", id);
                await connection.ExecuteAsync("spDeleteLocation", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<LocationDto>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<LocationDto>("spGetAllLocations", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<LocationDto> GetByIdAsync(int id)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("LocationID", id);
                return await connection.QueryFirstOrDefaultAsync<LocationDto>("spGetLocationById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task UpdateAsync(LocationDto location)
        {
            using (var connection = CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("LocationID", location.LocationID);
                parameters.Add("LocationName", location.LocationName);
                await connection.ExecuteAsync("spUpdateLocation", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
