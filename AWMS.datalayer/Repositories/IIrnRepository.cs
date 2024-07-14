using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IIrnRepository
    {
        Task<IEnumerable<Irn>> GetAllAsync();
        IEnumerable<Irn> GetAll();
        Task<Irn> GetByIdAsync(int IrnId);
        Task<Irn> GetByIrnNameAsync(string IrnName);
        Task<bool> ExistsByIrnNameAsync(string IrnName);
        Task<int> AddAsync(Irn Irn);
        void Update(Irn Irn);
        void Delete(Irn Irn);
    }
}
