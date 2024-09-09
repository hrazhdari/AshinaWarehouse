using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IIrnService
    {
        Task<IEnumerable<IrnDto>> GetAllIrnsAsync();
        IEnumerable<IrnDto> GetAllIrns();
        Task<IrnDto> GetIrnByIdAsync(int IrnId);
        Task<IrnDto> GetIrnByIrnNameAsync(string IrnName);
        Task<bool> ExistsByIrnNameAsync(string IrnName);
        Task<int> AddIrnAsync(IrnDto Irn);
        Task UpdateIrnAsync(IrnDto Irn);
        Task DeleteIrnAsync(int IrnId);
        Task DeleteMultipleIrnsWithTransactionAsync(IEnumerable<IrnDto> IrnDtos);
    }
}
