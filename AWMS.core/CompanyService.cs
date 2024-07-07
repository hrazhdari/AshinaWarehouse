using AWMS.datalayer;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.core.Interfaces;

namespace AWMS.core
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
        {
            return await _unitOfWork.Companies.GetAllAsync();
        }

        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            return await _unitOfWork.Companies.GetByIdAsync(id);
        }

        public async Task<int> AddCompanyAsync(Company company)
        {
            await _unitOfWork.Companies.AddAsync(company);
            await _unitOfWork.CompleteAsync();
            return company.CompanyID;
        }

        public async Task UpdateCompanyAsync(Company company)
        {
            _unitOfWork.Companies.Update(company);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCompanyAsync(int id)
        {
            var company = await _unitOfWork.Companies.GetByIdAsync(id);
            if (company != null)
            {
                _unitOfWork.Companies.Delete(company);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<int?> GetByCompanyNameAsync(string Companyname)
        {
            return await _unitOfWork.Companies.GetByNameAsync(Companyname);
        }
    }
}
