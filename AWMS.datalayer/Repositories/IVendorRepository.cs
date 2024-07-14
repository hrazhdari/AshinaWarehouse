using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IVendorRepository
    {
        Task<IEnumerable<Vendor>> GetAllAsync();
        IEnumerable<Vendor> GetAll();
        Task<Vendor> GetByIdAsync(int vendorId);
        Task<bool> ExistsVendorAsync(string VendorName);
        Task<int> AddAsync(Vendor vendor);
        void Update(Vendor vendor);
        void Delete(Vendor vendor);
    }
}
