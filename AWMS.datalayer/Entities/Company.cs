using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public  class Company
    {
        public Company()
        {
            EnteredDate= DateTime.Now;
        }
        //[NotMapped] // This attribute marks the property as not mapped to a database column
        //public int RowNumber { get; set; }
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string? Abbreviation { get; set; }
        public string? CompanyLogo { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnteredDate { get; set; }
        public int? Local_Foreign { get; set; }
        public string? Remark { get; set; }
        //public virtual ICollection<RequestMiv> RequestMivs { get; set; }
        //public virtual ICollection<RequestMRvHmv> ReturnFromCompaneis { get; set; }
        //public virtual ICollection<RequestMRvHmv> ReceiveByCompaneis { get; set; }
        //public virtual ICollection<CompanyContract> Contracts { get; set; }
    }
}
