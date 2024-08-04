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
    public class UserDapperRepository : IUserDapperRepository
    {
        private readonly string _connectionString;

        public UserDapperRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> AddUserAsync(UserDto user)
        {
            const string spName = "sp_AddUser";
            var parameters = new DynamicParameters();
            parameters.Add("@Username", user.Username);
            parameters.Add("@PasswordHash", user.PasswordHash);
            parameters.Add("@RoleID", user.RoleID);
            parameters.Add("@UserID", dbType: DbType.Int32, direction: ParameterDirection.Output);

            using (var connection = CreateConnection())
            {
                await connection.ExecuteAsync(spName, parameters, commandType: CommandType.StoredProcedure);
                return parameters.Get<int>("@UserID");
            }
        }

        public async Task<int> DeleteUserAsync(int userId)
        {
            const string spName = "sp_DeleteUser";
            var parameters = new { UserID = userId };

            using (var connection = CreateConnection())
            {
                return await connection.ExecuteAsync(spName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            const string spName = "sp_GetAllUsers";

            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<UserDto>(spName, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            const string spName = "sp_GetUserById";
            var parameters = new { UserID = userId };

            using (var connection = CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<UserDto>(spName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<UserDto> GetUserByUsernameAsync(string username)
        {
            const string spName = "sp_GetUserByUsername";
            var parameters = new { Username = username };

            using (var connection = CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<UserDto>(spName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> UpdateUserAsync(UserDto user)
        {
            const string spName = "sp_UpdateUser";
            var parameters = new
            {
                user.UserID,
                user.Username,
                user.PasswordHash,
                user.RoleID
            };

            using (var connection = CreateConnection())
            {
                return await connection.ExecuteAsync(spName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
