using AWMS.dto;
using AWMS.datalayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.core.Interfaces;
using AWMS.datalayer;

public class SupplierService : ISupplierService
{
    private readonly IUnitOfWork _unitOfWork;

    public SupplierService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync()
    {
        var suppliers = await _unitOfWork.Suppliers.GetAllAsync();
        return suppliers.Select(supplier => new SupplierDto
        {
            SupplierId = supplier.SupplierId,
            SupplierName = supplier.SupplierName,
            SupplierRemark = supplier.SupplierRemark,
            EnteredDate = supplier.EnteredDate
        }).ToList();
    }

    public IEnumerable<SupplierDto> GetAllSuppliers()
    {
        var suppliers = _unitOfWork.Suppliers.GetAll();
        return suppliers.Select(supplier => new SupplierDto
        {
            SupplierId = supplier.SupplierId,
            SupplierName = supplier.SupplierName,
            SupplierRemark = supplier.SupplierRemark,
            EnteredDate = supplier.EnteredDate
        }).ToList();
    }

    public async Task<SupplierDto> GetSupplierByIdAsync(int supplierId)
    {
        var supplier = await _unitOfWork.Suppliers.GetByIdAsync(supplierId);
        if (supplier == null) return null;

        return new SupplierDto
        {
            SupplierId = supplier.SupplierId,
            SupplierName = supplier.SupplierName,
            SupplierRemark = supplier.SupplierRemark,
            EnteredDate = supplier.EnteredDate
        };
    }

    public async Task<int> AddSupplierAsync(SupplierDto supplierDto)
    {
        var supplier = new Supplier
        {
            SupplierName = supplierDto.SupplierName,
            SupplierRemark = supplierDto.SupplierRemark,
            EnteredDate = supplierDto.EnteredDate
        };

        await _unitOfWork.Suppliers.AddAsync(supplier);
        await _unitOfWork.CompleteAsync();
        return supplier.SupplierId;
    }

    public async Task UpdateSupplierAsync(SupplierDto supplierDto)
    {
        var supplier = await _unitOfWork.Suppliers.GetByIdAsync(supplierDto.SupplierId);
        if (supplier != null)
        {
            supplier.SupplierName = supplierDto.SupplierName;
            supplier.SupplierRemark = supplierDto.SupplierRemark;
            supplier.EnteredDate = supplierDto.EnteredDate;

            _unitOfWork.Suppliers.Update(supplier);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteSupplierAsync(int supplierId)
    {
        var supplier = await _unitOfWork.Suppliers.GetByIdAsync(supplierId);
        if (supplier != null)
        {
            _unitOfWork.Suppliers.Delete(supplier);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteMultipleSuppliersWithTransactionAsync(IEnumerable<SupplierDto> supplierDtos)
    {
        using (var transaction = await _unitOfWork.BeginTransactionAsync())
        {
            try
            {
                foreach (var supplierDto in supplierDtos)
                {
                    var supplier = await _unitOfWork.Suppliers.GetByIdAsync(supplierDto.SupplierId);
                    if (supplier != null)
                    {
                        _unitOfWork.Suppliers.Delete(supplier);
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

    public async Task<bool> ExistsSupplierAsync(string SupplierName)
    {
        return await _unitOfWork.Suppliers.ExistsSupplierAsync(SupplierName);
    }
}
