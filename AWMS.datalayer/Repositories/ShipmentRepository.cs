using AWMS.datalayer.Context;
using AWMS.datalayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly AWMScontext _context;

        public ShipmentRepository(AWMScontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shipment>> GetAllAsync()
        {
            return await _context.Shipments.AsNoTracking().ToListAsync();
        }

        public IEnumerable<Shipment> GetAll()
        {
            return _context.Shipments.AsNoTracking().ToList();
        }

        public async Task<Shipment> GetByIdAsync(int ShipmentId)
        {
            var entity = await _context.Shipments.FindAsync(ShipmentId);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Shipment with ID {ShipmentId} not found.");
            }
            return entity;
        }

        public void Update(Shipment Shipment)
        {
            _context.Shipments.Update(Shipment);
            _context.SaveChanges();
        }

        public void Delete(Shipment Shipment)
        {
            _context.Shipments.Remove(Shipment);
            _context.SaveChanges();
        }

        public async Task<int> AddAsync(Shipment Shipment)
        {
            await _context.Shipments.AddAsync(Shipment);
            await _context.SaveChangesAsync();
            return Shipment.ShipmentId;
        }
        public async Task<bool> ExistsShipmentByShipmentNameAsync(string ShipmentName)
        {
            return await _context.Shipments.AsNoTracking().AnyAsync(i => i.ShipmentName == ShipmentName);
        }
    }
}
