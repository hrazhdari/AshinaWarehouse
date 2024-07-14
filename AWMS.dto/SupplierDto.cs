using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class SupplierDto
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string? SupplierRemark { get; set; }
        public DateTime? EnteredDate { get; set; }
    }
}
