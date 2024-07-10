using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Mr
    {
        public Mr()
        {
            EnteredDate=DateTime.Now;
        }
        [Key]
        public int MrId { get; set; }
        public string MrName { get; set; }
        public string? MrDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        //public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
