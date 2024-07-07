using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task<int?> GetByNameAsync(string name);
        Task<int> AddAsync(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
