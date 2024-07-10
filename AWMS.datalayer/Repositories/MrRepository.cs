using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AWMS.datalayer.Repositories
{
    public class MrRepository : IMrRepository
    {
        private readonly AWMScontext _context;

        public MrRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mr>> GetAllAsync()
        {
            return await _context.Mrs.ToListAsync();
        }

        public async Task<Mr> GetByIdAsync(int id)
        {
            return await _context.Mrs.FindAsync(id);
        }

        public void Update(Mr mr)
        {
            _context.Mrs.Update(mr);
            _context.SaveChanges();
        }

        public void Delete(Mr mr)
        {
            _context.Mrs.Remove(mr);
            _context.SaveChanges();
        }

        public async Task<int?> GetByNameAsync(string MrName)
        {
            return await _context.Mrs
                      .Where(p => p.MrName==MrName)
                      .Select(p => (int?)p.MrId)
                      .FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(Mr mr)
        {
            await _context.Mrs.AddAsync(mr);
            await _context.SaveChangesAsync();
            return mr.MrId;
        }
    }
}
