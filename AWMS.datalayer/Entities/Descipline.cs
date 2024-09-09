using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Descipline
    {
        public Descipline()
        {
            
        }

        [Key]
        public int DesciplineId { get; set; }
        [Required]
        [MaxLength(200)]
        public string DesciplineName { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
