using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AWMS.datalayer.Repositories
{
    public class CompanyContractRepository : ICompanyContract
    {
        private readonly AWMScontext _context;

        public CompanyContractRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CompanyContract>> GetAllAsync()
        {
            return await _context.CompanyContracts.ToListAsync();
        }

        public CompanyContract GetByIdAsync(int id)
        {
            return  _context.CompanyContracts.Find(id);
        }

        public void Update(CompanyContract CompanyContract)
        {
            _context.CompanyContracts.Update(CompanyContract);
            _context.SaveChanges();
        }

        public void Delete(CompanyContract CompanyContract)
        {
            _context.CompanyContracts.Remove(CompanyContract);
            _context.SaveChanges();
        }

        public async Task<int?> GetByNameAsync(string name)
        {
            return await _context.CompanyContracts
                      .Where(p => p.ContractNumber.Contains(name))
                      .Select(p => (int?)p.CompanyID)
                      .FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(CompanyContract companyContract)
        {
            await _context.CompanyContracts.AddAsync(companyContract);
            await _context.SaveChangesAsync();
            return companyContract.ContractId;
        }
    }
}
