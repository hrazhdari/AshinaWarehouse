using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.datalayer.Repositories
{
    public interface IShipmentRepository
    {
        Task<IEnumerable<Shipment>> GetAllAsync();
        IEnumerable<Shipment> GetAll();
        Task<Shipment> GetByIdAsync(int ShipmentId);
        Task<bool> ExistsShipmentByShipmentNameAsync(string ShipmentName);
        Task<int> AddAsync(Shipment Shipment);
        void Update(Shipment Shipment);
        void Delete(Shipment Shipment);
    }
}
