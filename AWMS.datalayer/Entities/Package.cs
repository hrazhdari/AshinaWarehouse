using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Package
    {
        public Package()
        {

        }
        [Key] 
        public int PKID { get; set; }
        public int PLId { get; set; }
        public int PK { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public string? Dimension { get; set; }
        public string? Volume { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ArrivalDate { get; set; }
        public string? Desciption { get; set; }
        public string? Remark { get; set; }
        public int? EnteredBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        public int? EditedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; private set; }
        public string? MSRNO { get;  set; }
        public string? MSRPDF { get; set; }
        [DataType(DataType.Date)]
        public DateTime? MSRDate { get; set; }
        public int? MSREnteredBy { get; set; }
        public bool? MSRStatus { get; set; }
        public int? MSRRev { get;  set; }
        public int? MSRRevEnteredBy { get;  set; }
        [DataType(DataType.Date)]
        public DateTime? MSRRevDate { get;  set; }

        public virtual PackingList PackingList { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
