using AWMS.datalayer.Entities;
using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IContractService
    {
        Task<IEnumerable<CompanyContract>> GetAllContractsAsync();
        CompanyContract GetContractByIdAsync(int id);
        Task<int?> GetByContractNumberAsync(string ContractNumber);
        Task<int> AddCompanyContractAsync(CompanyContract CompanyContract);
        Task UpdateCompanyContractAsync(CompanyContract CompanyContract);
        Task DeleteCompanyContractAsync(int id);
        Task DeleteMultipleContractsWithTransactionAsync(IEnumerable<CompanyContract> Contracts);
    }
}
