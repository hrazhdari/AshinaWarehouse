using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Supplier
    {
        public Supplier()
        {
            
        }
        [Key]
        public int SupplierId { get; set; }
        [Required]
        [MaxLength(200)]
        public string SupplierName { get; set; }
        [MaxLength(500)]
        public string? SupplierRemark { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
