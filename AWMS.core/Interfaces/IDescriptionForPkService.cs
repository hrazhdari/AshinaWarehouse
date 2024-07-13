using AWMS.datalayer.Entities;
using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IDescriptionForPkService
    {
        Task<IEnumerable<DescriptionForPkDto>> GetAllDescriptionForPksAsync();
        IEnumerable<DescriptionForPkDto> GetAllDescriptionForPks();
        Task<DescriptionForPkDto> GetDescriptionForPkByIdAsync(int DescriptionForPkId);
        Task<int> AddDescriptionForPkAsync(DescriptionForPkDto DescriptionForPk);
        Task UpdateDescriptionForPkAsync(DescriptionForPkDto DescriptionForPk);
        Task DeleteDescriptionForPkAsync(int DescriptionForPkId);
        Task DeleteMultipleDescriptionForPksWithTransactionAsync(IEnumerable<DescriptionForPkDto> DescriptionForPkDtos);
    }
}
