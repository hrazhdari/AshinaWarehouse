using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class Po
    {
        public Po()
        {
            
        }
        [Key]
        public int PoId { get; set; }
        public int? MrId { get; set; }
        [Required]
        [MaxLength(150)]
        public string PoName { get; set; }
        [MaxLength(500)]
        public string? PoDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        
        public virtual Mr Mr { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
