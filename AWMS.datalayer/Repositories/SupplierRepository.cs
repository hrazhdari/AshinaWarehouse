using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AWMScontext _context;

        public SupplierRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public async Task<Supplier> GetByIdAsync(int supplierId)
        {
            var entity = await _context.Suppliers.FindAsync(supplierId);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Supplier with ID {supplierId} not found.");
            }
            return entity;
        }

        public async Task<int> AddAsync(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
            return supplier.SupplierId;
        }

        public void Update(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }

        public void Delete(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }

        public async Task<bool> ExistsSupplierAsync(string SupplierName)
        {
            return await _context.Suppliers.AnyAsync(i => i.SupplierName == SupplierName);
        }
    }
}
