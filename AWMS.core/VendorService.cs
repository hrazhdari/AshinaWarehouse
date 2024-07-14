using AWMS.core.Interfaces;
using AWMS.dto;
using AWMS.datalayer.Entities;
using AWMS.datalayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWMS.datalayer;

public class VendorService : IVendorService
{
    private readonly IUnitOfWork _unitOfWork;

    public VendorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<VendorDto>> GetAllVendorsAsync()
    {
        var vendors = await _unitOfWork.Vendors.GetAllAsync();
        return vendors.Select(vendor => new VendorDto
        {
            VendorID = vendor.VendorID,
            VendorName = vendor.VendorName,
            VendorContractNO = vendor.VendorContractNO,
            VendorContractDescription = vendor.VendorContractDescription,
            VendorAbbreviation = vendor.VendorAbbreviation,
            EnteredDate = vendor.EnteredDate,
            Local_Foreign = vendor.Local_Foreign,
            Remark = vendor.Remark
        }).ToList();
    }

    public IEnumerable<VendorDto> GetAllVendors()
    {
        var vendors = _unitOfWork.Vendors.GetAll();
        return vendors.Select(vendor => new VendorDto
        {
            VendorID = vendor.VendorID,
            VendorName = vendor.VendorName,
            VendorContractNO = vendor.VendorContractNO,
            VendorContractDescription = vendor.VendorContractDescription,
            VendorAbbreviation = vendor.VendorAbbreviation,
            EnteredDate = vendor.EnteredDate,
            Local_Foreign = vendor.Local_Foreign,
            Remark = vendor.Remark
        }).ToList();
    }

    public async Task<VendorDto> GetVendorByIdAsync(int vendorId)
    {
        var vendor = await _unitOfWork.Vendors.GetByIdAsync(vendorId);
        if (vendor == null)
            return null;

        return new VendorDto
        {
            VendorID = vendor.VendorID,
            VendorName = vendor.VendorName,
            VendorContractNO = vendor.VendorContractNO,
            VendorContractDescription = vendor.VendorContractDescription,
            VendorAbbreviation = vendor.VendorAbbreviation,
            EnteredDate = vendor.EnteredDate,
            Local_Foreign = vendor.Local_Foreign,
            Remark = vendor.Remark
        };
    }

    public async Task<int> AddVendorAsync(VendorDto vendorDto)
    {
        var vendor = new Vendor
        {
            VendorName = vendorDto.VendorName,
            VendorContractNO = vendorDto.VendorContractNO,
            VendorContractDescription = vendorDto.VendorContractDescription,
            VendorAbbreviation = vendorDto.VendorAbbreviation,
            EnteredDate = vendorDto.EnteredDate,
            Local_Foreign = vendorDto.Local_Foreign,
            Remark = vendorDto.Remark
        };

        await _unitOfWork.Vendors.AddAsync(vendor);
        await _unitOfWork.CompleteAsync();
        return vendor.VendorID;
    }

    public async Task UpdateVendorAsync(VendorDto vendorDto)
    {
        var vendor = await _unitOfWork.Vendors.GetByIdAsync(vendorDto.VendorID);
        if (vendor != null)
        {
            vendor.VendorName = vendorDto.VendorName;
            vendor.VendorContractNO = vendorDto.VendorContractNO;
            vendor.VendorContractDescription = vendorDto.VendorContractDescription;
            vendor.VendorAbbreviation = vendorDto.VendorAbbreviation;
            vendor.EnteredDate = vendorDto.EnteredDate;
            vendor.Local_Foreign = vendorDto.Local_Foreign;
            vendor.Remark = vendorDto.Remark;

            _unitOfWork.Vendors.Update(vendor);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task DeleteVendorAsync(int vendorId)
    {
        var vendor = await _unitOfWork.Vendors.GetByIdAsync(vendorId);
        if (vendor != null)
        {
            _unitOfWork.Vendors.Delete(vendor);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task<bool> ExistsVendorAsync(string VendorName)
    {
        return await _unitOfWork.Vendors.ExistsVendorAsync(VendorName);
    }
}
