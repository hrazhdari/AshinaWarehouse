using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Po
    {
        public Po()
        {
            EnteredDate=DateTime.Now;
        }
        [Key]
        public int PoId { get; set; }
        public int? MrId { get; set; }
        public string PoName { get; set; }
        public string? PoDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        [ForeignKey(nameof(MrId))]
        public virtual  Mr Mr { get; set; }
        //public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
