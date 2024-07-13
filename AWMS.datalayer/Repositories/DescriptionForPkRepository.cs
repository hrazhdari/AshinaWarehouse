using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AWMS.datalayer.Repositories
{
    public class DescriptionForPkRepository : IDescriptionForPkRepository
    {
        private readonly AWMScontext _context;

        public DescriptionForPkRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DescriptionForPk>> GetAllAsync()
        {

            return await _context.DescriptionForPks.ToListAsync();
        }
        public IEnumerable<DescriptionForPk> GetAll()
        {
            return  _context.DescriptionForPks.ToList();
        }

        public async Task<DescriptionForPk> GetByIdAsync(int DescriptionForPkId)
        {
            var entity = await _context.DescriptionForPks.FindAsync(DescriptionForPkId);
            if (entity == null)
            {
                throw new KeyNotFoundException($"DescriptionForPk with ID {DescriptionForPkId} not found.");
            }
            return entity;
        }

        public void Update(DescriptionForPk DescriptionForPk)
        {
            _context.DescriptionForPks.Update(DescriptionForPk);
            _context.SaveChanges();
        }

        public void Delete(DescriptionForPk DescriptionForPk)
        {
            _context.DescriptionForPks.Remove(DescriptionForPk);
            _context.SaveChanges();
        }

        public async Task<int> AddAsync(DescriptionForPk DescriptionForPk)
        {
            await _context.DescriptionForPks.AddAsync(DescriptionForPk);
            await _context.SaveChangesAsync();
            return DescriptionForPk.DescriptionForPkId;
        }
    }
}
