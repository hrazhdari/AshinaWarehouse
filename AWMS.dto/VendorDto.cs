using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class VendorDto
    {
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string? VendorContractNO { get; set; }
        public string? VendorContractDescription { get; set; }
        public string? VendorAbbreviation { get; set; }
        public DateTime? EnteredDate { get; set; }
        public int? Local_Foreign { get; set; }
        public string? Remark { get; set; }
    }
}
