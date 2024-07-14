using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWMS.dto;

namespace AWMS.dapper.Repositories
{
    public interface IPackingListDapperRepository
    {
        Task<IEnumerable<PackingListDto>> GetAllAsync();
        Task<PackingListDto> GetByIdAsync(int PlId);
        Task<PackingListDto> GetByPlNameAsync(string PlName);
        Task<bool> ExistsByPlNameAsync(string plName);
        Task<bool> ExistsByPlNoAsync(string PlNo);
        bool ExistsByOpiNumber(string OpiNumber);
        string LastArchiveNo();
        Task<bool> AddAsync(PackingListDto PackingList);
        Task UpdateAsync(PackingListDto PackingList);
        Task DeleteAsync(int PlId);
    }
}
