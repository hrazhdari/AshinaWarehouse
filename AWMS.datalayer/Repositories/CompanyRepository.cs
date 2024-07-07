using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AWMS.datalayer.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AWMScontext _context;

        public CompanyRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }

        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }

        public async Task<int?> GetByNameAsync(string name)
        {
            return await _context.Companies
                      .Where(p => p.CompanyName.Contains(name))
                      .Select(p => (int?)p.CompanyID)
                      .FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company.CompanyID;
        }
    }
}
