using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class IrnRepository : IIrnRepository
    {
        private readonly AWMScontext _context;

        public IrnRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Irn>> GetAllAsync()
        {
            return await _context.Irns.ToListAsync();
        }

        public IEnumerable<Irn> GetAll()
        {
            return _context.Irns.ToList();
        }

        public async Task<Irn> GetByIdAsync(int IrnId)
        {
            var entity = await _context.Irns.FindAsync(IrnId);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Irn with ID {IrnId} not found.");
            }
            return entity;
        }

        public void Update(Irn Irn)
        {
            _context.Irns.Update(Irn);
            _context.SaveChanges();
        }

        public void Delete(Irn Irn)
        {
            _context.Irns.Remove(Irn);
            _context.SaveChanges();
        }

        public async Task<int> AddAsync(Irn Irn)
        {
            await _context.Irns.AddAsync(Irn);
            await _context.SaveChangesAsync();
            return Irn.IrnId;
        }

        public async Task<Irn> GetByIrnNameAsync(string IrnName)
        {
            var entity = await _context.Irns.FindAsync(IrnName);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Irn with name {IrnName} not found.");
            }
            return entity;
        }

        public async Task<bool> ExistsByIrnNameAsync(string IrnName)
        {
            return await _context.Irns.AnyAsync(i => i.IrnName == IrnName);
        }

    }
}
