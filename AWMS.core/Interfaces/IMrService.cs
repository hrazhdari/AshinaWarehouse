using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IMrService
    {
        Task<IEnumerable<Mr>> GetAllMrsAsync();
        Task<Mr> GetMrByIdAsync(int id);
        Task<int?> GetByMrNameAsync(string MrName);
        Task<int> AddMrAsync(Mr Mr);
        Task UpdateMrAsync(Mr Mr);
        Task DeleteMrAsync(int MrId);
        Task DeleteMultipleMrsWithTransactionAsync(IEnumerable<Mr> mrs);
    }
}
