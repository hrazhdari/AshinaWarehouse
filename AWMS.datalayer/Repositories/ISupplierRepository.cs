using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllAsync();
        IEnumerable<Supplier> GetAll();
        Task<Supplier> GetByIdAsync(int supplierId);
        Task<bool> ExistsSupplierAsync(string SupplierName);
        Task<int> AddAsync(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}
