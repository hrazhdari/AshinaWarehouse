using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class Scope
    {
        public Scope() { }
        [Key]
        public int ScopeID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ScopeName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
