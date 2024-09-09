using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IAreaUnitRepository
    {
        Task<IEnumerable<AreaUnit>> GetAllAsync();
        IEnumerable<AreaUnit> GetAll();
        Task<AreaUnit> GetByIdAsync(int AreaUnitID);
        Task<bool> ExistsAreaUnitAsync(string AreaUnitName);
        Task<int> AddAsync(AreaUnit AreaUnit);
        void Update(AreaUnit AreaUnit);
        void Delete(AreaUnit AreaUnit);
    }
}
