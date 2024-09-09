using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface ICompanyContract
    {
        Task<IEnumerable<CompanyContract>> GetAllAsync();
        CompanyContract GetByIdAsync(int id);
        Task<int?> GetByNameAsync(string name);
        Task<int> AddAsync(CompanyContract CompanyContract);
        void Update(CompanyContract CompanyContract);
        void Delete(CompanyContract CompanyContract);
    }
}
