using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class DescriptionForPk
    {
        public DescriptionForPk()
        {
            
        }
        [Key]   
        public int DescriptionForPkId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
