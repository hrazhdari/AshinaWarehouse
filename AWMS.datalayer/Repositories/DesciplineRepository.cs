using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class DesciplineRepository : IDesciplineRepository
    {
        private readonly AWMScontext _context;

        public DesciplineRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Descipline>> GetAllAsync()
        {
            return await _context.Desciplines.ToListAsync();
        }

        public IEnumerable<Descipline> GetAll()
        {
            return _context.Desciplines.ToList();
        }

        public async Task<Descipline> GetByIdAsync(int desciplineId)
        {
            var entity = await _context.Desciplines.FindAsync(desciplineId);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Descipline with ID {desciplineId} not found.");
            }
            return entity;
        }

        public void Update(Descipline descipline)
        {
            _context.Desciplines.Update(descipline);
            _context.SaveChanges();
        }

        public void Delete(Descipline descipline)
        {
            _context.Desciplines.Remove(descipline);
            _context.SaveChanges();
        }

        public async Task<int> AddAsync(Descipline descipline)
        {
            await _context.Desciplines.AddAsync(descipline);
            await _context.SaveChangesAsync();
            return descipline.DesciplineId;
        }
    }
}
