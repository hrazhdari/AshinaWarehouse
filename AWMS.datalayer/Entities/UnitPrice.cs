using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class UnitPrice
    {
        [Key]
        public int UnitPriceID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UnitPriceName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
