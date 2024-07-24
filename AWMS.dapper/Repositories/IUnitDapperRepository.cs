using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.dto;

namespace AWMS.dapper.Repositories
{
    public interface IUnitDapperRepository
    {
        Task<IEnumerable<UnitDto>> GetAllAsync();
        IEnumerable<UnitDto> GetAll();
        Task<UnitDto> GetByIdAsync(int id);
        Task AddAsync(UnitDto unit);
        Task UpdateAsync(UnitDto unit);
        Task DeleteAsync(int id);
    }
}
