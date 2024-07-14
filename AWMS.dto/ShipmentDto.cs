using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class ShipmentDto
    {
        public int ShipmentId { get; set; }
        public int? PoId { get; set; }
        public string ShipmentName { get; set; }
        public string? ShipmentDescription { get; set; }
        public DateTime? EnteredDate { get; set; }
    }
}
