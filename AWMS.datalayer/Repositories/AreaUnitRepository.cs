using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class AreaUnitRepository : IAreaUnitRepository
    {
        private readonly AWMScontext _context;

        public AreaUnitRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AreaUnit>> GetAllAsync()
        {
            return await _context.AreaUnits.AsNoTracking().ToListAsync();
        }

        public IEnumerable<AreaUnit> GetAll()
        {
            return _context.AreaUnits.AsNoTracking().ToList();
        }

        public async Task<AreaUnit> GetByIdAsync(int AreaUnitID)
        {
            var entity = await _context.AreaUnits.FindAsync(AreaUnitID);
            if (entity == null)
            {
                throw new KeyNotFoundException($"AreaUnit with ID {AreaUnitID} not found.");
            }
            return entity;
        }

        public void Update(AreaUnit AreaUnit)
        {
            _context.AreaUnits.Update(AreaUnit);
            _context.SaveChanges();
        }

        public void Delete(AreaUnit AreaUnit)
        {
            _context.AreaUnits.Remove(AreaUnit);
            _context.SaveChanges();
        }

        public async Task<int> AddAsync(AreaUnit AreaUnit)
        {
            await _context.AreaUnits.AddAsync(AreaUnit);
            await _context.SaveChangesAsync();
            return AreaUnit.AreaUnitID;
        }
        public async Task<bool> ExistsAreaUnitAsync(string AreaUnitName)
        {
            return await _context.AreaUnits.AnyAsync(i => i.AreaUnitName == AreaUnitName);
        }
    }
}
