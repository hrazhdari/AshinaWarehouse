
using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class UpdatePackageDto
    {
        public int PKID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ArrivalDate { get; set; }
        public string? MSRNO { get; set; }
        public string? MSRPDF { get; set; }
        public int? EditedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
    }
}
