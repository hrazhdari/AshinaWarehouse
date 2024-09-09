using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class Unit
    {
        public Unit()
        {
            
        }
        [Key]
        public int UnitID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UnitName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
