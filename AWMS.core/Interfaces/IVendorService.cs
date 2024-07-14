using AWMS.dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWMS.core.Interfaces
{
    public interface IVendorService
    {
        Task<IEnumerable<VendorDto>> GetAllVendorsAsync();
        IEnumerable<VendorDto> GetAllVendors();
        Task<VendorDto> GetVendorByIdAsync(int vendorId);
        Task<bool> ExistsVendorAsync(string VendorName);
        Task<int> AddVendorAsync(VendorDto vendorDto);
        Task UpdateVendorAsync(VendorDto vendorDto);
        Task DeleteVendorAsync(int vendorId);
    }
}
