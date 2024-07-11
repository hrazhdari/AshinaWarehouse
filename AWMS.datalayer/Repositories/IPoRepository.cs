using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IPoRepository
    {
        Task<IEnumerable<Po>> GetAllAsync();
        IEnumerable<Po> GetAll();
        Task<Po> GetByIdAsync(int id);
        Task<int?> GetByNameAsync(string PoName);
        Task<int> AddAsync(Po Po);
        void Update(Po Po);
        void Delete(Po Po);
    }
}
