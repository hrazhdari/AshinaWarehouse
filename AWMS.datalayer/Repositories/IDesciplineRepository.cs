using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IDesciplineRepository
    {
        Task<IEnumerable<Descipline>> GetAllAsync();
        IEnumerable<Descipline> GetAll();
        Task<Descipline> GetByIdAsync(int desciplineId);
        Task<int> AddAsync(Descipline descipline);
        void Update(Descipline descipline);
        void Delete(Descipline descipline);
    }
}
