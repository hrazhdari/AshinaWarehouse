using AWMS.datalayer;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.core.Interfaces;

namespace AWMS.core
{
    public class ContractService : IContractService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContractService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CompanyContract>> GetAllContractsAsync()
        {
            return await _unitOfWork.Contratcs.GetAllAsync();
        }

        public CompanyContract GetContractByIdAsync(int id)
        {
            return  _unitOfWork.Contratcs.GetByIdAsync(id);
        }

        public async Task<int> AddCompanyContractAsync(CompanyContract CompanyContract)
        {
            await _unitOfWork.Contratcs.AddAsync(CompanyContract);
            await _unitOfWork.CompleteAsync();
            return CompanyContract.ContractId;
        }

        public async Task UpdateCompanyContractAsync(CompanyContract CompanyContract)
        {
            _unitOfWork.Contratcs.Update(CompanyContract);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCompanyContractAsync(int id)
        {
            var companycontract =  _unitOfWork.Contratcs.GetByIdAsync(id);
            if (companycontract != null)
            {
                _unitOfWork.Contratcs.Delete(companycontract);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<int?> GetByContractNumberAsync(string ContractNumber)
        {
            return await _unitOfWork.Contratcs.GetByNameAsync(ContractNumber);
        }

        public async Task DeleteMultipleContractsWithTransactionAsync(IEnumerable<CompanyContract> Contracts)
        {
            using (var transaction = await _unitOfWork.BeginTransactionAsync())
            {
                try
                {
                    foreach (var Contract in Contracts)
                    {
                        var Contracto =  _unitOfWork.Contratcs.GetByIdAsync(Contract.ContractId);
                        if (Contracto != null)
                        {
                            _unitOfWork.Contratcs.Delete(Contracto);
                        }
                    }
                    await _unitOfWork.CompleteAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}
