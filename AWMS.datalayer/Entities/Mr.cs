using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class Mr
    {
        public Mr()
        {
            
        }
        [Key]
        public int MrId { get; set; }

        [Required]
        [MaxLength(100)]
        public string MrName { get; set; }

        [MaxLength(500)]
        public string? MrDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }

        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
