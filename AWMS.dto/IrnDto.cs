using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class IrnDto
    {
        public int IrnId { get; set; }
        public string IrnName { get; set; }
        public string? IrnDescription { get; set; }
        public string? IrnPdf { get; set; }
        public DateTime? EnteredDate { get; set; }
    }
}
