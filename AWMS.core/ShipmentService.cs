using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class ShipmentService : IShipmentService
{
    private readonly IUnitOfWork _unitOfWork;

    public ShipmentService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ShipmentDto>> GetAllShipmentsAsync()
    {
        var Shipments = await _unitOfWork.Shipments.GetAllAsync();
        return Shipments.Select(Shipment => new ShipmentDto
        {
            ShipmentId = Shipment.ShipmentId,
            PoId = Shipment.PoId,
            ShipmentName = Shipment.ShipmentName,
            ShipmentDescription = Shipment.ShipmentDescription,
            EnteredDate = Shipment.EnteredDate
        }).ToList();
    }

    public IEnumerable<ShipmentDto> GetAllShipments()
    {
        var Shipments = _unitOfWork.Shipments.GetAll();
        return Shipments.Select(Shipment => new ShipmentDto
        {
            ShipmentId = Shipment.ShipmentId,
            PoId = Shipment.PoId,
            ShipmentName = Shipment.ShipmentName,
            ShipmentDescription = Shipment.ShipmentDescription,
            EnteredDate = Shipment.EnteredDate
        }).ToList();
    }

    public async Task<ShipmentDto> GetShipmentByIdAsync(int ShipmentId)
    {
        var Shipment = await _unitOfWork.Shipments.GetByIdAsync(ShipmentId);
        if (Shipment == null) return null;

        return new ShipmentDto
        {
            ShipmentId = Shipment.ShipmentId,
            PoId = Shipment.PoId,
            ShipmentName = Shipment.ShipmentName,
            ShipmentDescription = Shipment.ShipmentDescription,
            EnteredDate = Shipment.EnteredDate
        };
    }

    public async Task<int> AddShipmentAsync(ShipmentDto ShipmentDto)
    {
        var Shipment = new Shipment
        {
            PoId = ShipmentDto.PoId,
            ShipmentName = ShipmentDto.ShipmentName,
            ShipmentDescription = ShipmentDto.ShipmentDescription,
            EnteredDate = ShipmentDto.EnteredDate
        };

        await _unitOfWork.Shipments.AddAsync(Shipment);
        await _unitOfWork.CompleteAsync();
        return Shipment.ShipmentId;
    }

    public async Task UpdateShipmentAsync(ShipmentDto ShipmentDto)
    {
        var Shipment = await _unitOfWork.Shipments.GetByIdAsync(ShipmentDto.ShipmentId);
        if (Shipment != null)
        {
            Shipment.PoId = ShipmentDto.PoId;
            Shipment.ShipmentName = ShipmentDto.ShipmentName;
            Shipment.ShipmentDescription = ShipmentDto.ShipmentDescription;
            Shipment.EnteredDate = ShipmentDto.EnteredDate;

            _unitOfWork.Shipments.Update(Shipment);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteShipmentAsync(int ShipmentId)
    {
        var Shipment = await _unitOfWork.Shipments.GetByIdAsync(ShipmentId);
        if (Shipment != null)
        {
            _unitOfWork.Shipments.Delete(Shipment);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteMultipleShipmentsWithTransactionAsync(IEnumerable<ShipmentDto> ShipmentDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var ShipmentDto in ShipmentDtos)
                {
                    var Shipment = await _unitOfWork.Shipments.GetByIdAsync(ShipmentDto.ShipmentId);
                    if (Shipment != null)
                    {
                        _unitOfWork.Shipments.Delete(Shipment);
                    }
                }
                await _unitOfWork.CompleteAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }

    public async Task<bool> ExistsShipmentByShipmentNameAsync(string ShipmentName)
    {
        return await _unitOfWork.Shipments.ExistsShipmentByShipmentNameAsync(ShipmentName);
    }
}
