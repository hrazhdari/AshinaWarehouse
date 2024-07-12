using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWMS.dto;

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
            return await _context.Mrs.AsNoTracking().ToListAsync();
        }

        public IEnumerable<Mr> GetAll()
        {
            return _context.Mrs.AsNoTracking().ToList();
        }

        public async Task<IEnumerable<MrIdAndMrNameDto>> GetMrIdAndNameAsync()
        {
            return await _context.Mrs
                .AsNoTracking()
                .Select(mr => new MrIdAndMrNameDto
                {
                    MrId = mr.MrId,
                    MrName = mr.MrName
                })
                .ToListAsync();
        }

        public IEnumerable<MrIdAndMrNameDto> GetMrIdAndName()
        {
            return _context.Mrs
                .AsNoTracking()
                .Select(mr => new MrIdAndMrNameDto
                {
                    MrId = mr.MrId,
                    MrName = mr.MrName
                })
                .ToList();
        }

        public async Task<Mr> GetByIdAsync(int id)
        {
            return await _context.Mrs.FindAsync(id);
        }

        public async Task UpdateAsync(Mr mr)
        {
            _context.Mrs.Update(mr);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Mr mr)
        {
            _context.Mrs.Remove(mr);
            await _context.SaveChangesAsync();
        }

        public async Task<int?> GetByNameAsync(string MrName)
        {
            return await _context.Mrs
                .AsNoTracking()
                .Where(p => p.MrName == MrName)
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
