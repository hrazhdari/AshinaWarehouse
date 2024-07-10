using AWMS.datalayer.Entities;
using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IPoService
    {
        Task<IEnumerable<PoDto>> GetAllPosAsync();
        Task<PoDto> GetPoByIdAsync(int id);
        Task<int?> GetByPoNameAsync(string PoName);
        Task<int> AddPoAsync(PoDto Po);
        Task UpdatePoAsync(PoDto Po);
        Task DeletePoAsync(int PoId);
        Task DeleteMultiplePosWithTransactionAsync(IEnumerable<PoDto> Pos);
        Task<IEnumerable<PoIdAndPoNameDto>> GetPoIdAndNameAsync();
    }
}
