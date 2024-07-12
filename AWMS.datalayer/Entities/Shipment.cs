using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Shipment
    {
        public Shipment()
        {
            
        }
        [Key]
        public int ShipmentId { get; set; }
        public int? PoId { get; set; }
        [Required]
        [MaxLength(150)]
        public string ShipmentName { get; set; }
        [MaxLength(500)]
        public string? ShipmentDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        public virtual Po Po { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
