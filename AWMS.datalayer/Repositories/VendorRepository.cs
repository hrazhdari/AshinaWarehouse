using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly AWMScontext _context;

        public VendorRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vendor>> GetAllAsync()
        {
            return await _context.Vendors.ToListAsync();
        }

        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }

        public async Task<Vendor> GetByIdAsync(int vendorId)
        {
            var vendor = await _context.Vendors.FindAsync(vendorId);
            if (vendor == null)
            {
                throw new KeyNotFoundException($"Vendor with ID {vendorId} not found.");
            }
            return vendor;
        }

        public async Task<int> AddAsync(Vendor vendor)
        {
            await _context.Vendors.AddAsync(vendor);
            await _context.SaveChangesAsync();
            return vendor.VendorID;
        }

        public void Update(Vendor vendor)
        {
            _context.Vendors.Update(vendor);
            _context.SaveChanges();
        }

        public void Delete(Vendor vendor)
        {
            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
        }

        public async Task<bool> ExistsVendorAsync(string VendorName)
        {
            return await _context.Vendors.AnyAsync(i => i.VendorName == VendorName);
        }
    }
}
