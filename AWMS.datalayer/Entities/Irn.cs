using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Irn
    {
        public Irn()
        {
         
        }
        [Key]
        public int IrnId { get; set; }
        [Required]
        [MaxLength(200)]
        public string IrnName { get; set; }
        [MaxLength(500)]
        public string? IrnDescription { get; set; }
        public string? IrnPdf { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
