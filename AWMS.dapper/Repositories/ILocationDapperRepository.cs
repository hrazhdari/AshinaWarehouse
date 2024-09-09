using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.dto;

namespace AWMS.dapper.Repositories
{
    public interface ILocationDapperRepository
    {
        Task<IEnumerable<LocationDto>> GetAllAsync();
        Task<LocationDto> GetByIdAsync(int id);
        Task AddAsync(LocationDto location);
        Task UpdateAsync(LocationDto location);
        Task DeleteAsync(int id);
    }
}
