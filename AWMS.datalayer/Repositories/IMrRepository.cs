using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IMrRepository
    {
        Task<IEnumerable<Mr>> GetAllAsync();
        Task<IEnumerable<MrIdAndMrNameDto>> GetMrIdAndNameAsync();
        Task<Mr> GetByIdAsync(int id);
        Task<int?> GetByNameAsync(string MrName);
        Task<int> AddAsync(Mr mr);
        void Update(Mr mr);
        void Delete(Mr mr);
    }
}
