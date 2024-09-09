using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using AWMS.dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AWMS.datalayer.Repositories
{
    public class PoRepository : IPoRepository
    {
        private readonly AWMScontext _context;

        public PoRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Po>> GetAllAsync()
        {

            return await _context.Pos.ToListAsync();
        }
        public IEnumerable<Po> GetAll()
        {
            return _context.Pos.ToList();
        }

        public async Task<Po> GetByIdAsync(int id)
        {
            return await _context.Pos.FindAsync(id);
        }

        public void Update(Po Po)
        {
            _context.Pos.Update(Po);
            _context.SaveChanges();
        }

        public void Delete(Po Po)
        {
            _context.Pos.Remove(Po);
            _context.SaveChanges();
        }

        public async Task<int?> GetByNameAsync(string PoName)
        {
            return await _context.Pos
                  .Where(p => p.PoName == PoName)
                  .Select(p => (int?)p.PoId)
                  .FirstOrDefaultAsync();
        }
        public async Task<int> AddAsync(Po Po)
        {
            await _context.Pos.AddAsync(Po);
            await _context.SaveChangesAsync();
            return Po.PoId;
        }

        public IEnumerable<PoIdAndPoNameDto> GetPoIdAndName()
        {
            return _context.Pos
             .AsNoTracking()
             .Select(po => new PoIdAndPoNameDto
             {
                 PoId = po.PoId,
                 PoName = po.PoName
             })
             .ToList();
        }
    }
}
