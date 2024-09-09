using AWMS.datalayer.Entities;
using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IMrService
    {
        Task<IEnumerable<MrDto>> GetAllMrsAsync();
        IEnumerable<MrDto> GetAllMrs();
        Task<MrDto> GetMrByIdAsync(int id);
        Task<int?> GetByMrNameAsync(string MrName);
        Task<int> AddMrAsync(MrDto Mr);
        Task UpdateMrAsync(MrDto Mr);
        Task DeleteMrAsync(int MrId);
        Task DeleteMultipleMrsWithTransactionAsync(IEnumerable<MrDto> mrs);
        Task<IEnumerable<MrIdAndMrNameDto>> GetMrIdAndNameAsync();
        IEnumerable<MrIdAndMrNameDto> GetMrIdAndName();
    }
}
