using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class RequestMiv
    {
        public RequestMiv()
        {
            
        }
        [Key]
        public int ReqMivLocItemID { get; set; }
        public int? LocItemID { get; set; }
        public int? CompanyID { get; set; }
        public int? ContractId { get; set; }
        public int? AreaUnitID { get; set; }
        public string RequestMIVorREJMIV { get; set; }
        public string RequestMivNO { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReqDate { get; set; }
        public int? Item { get; set; }
        public decimal? ReqMivQty { get; set; }
        public decimal? ReserveMivQty { get; set; }
        public decimal? DelMivQty { get; set; }
        public bool? RejectOrNotReject {  get; set; }
        public decimal? ReqMivRejQty { get; set; }
        public decimal? ReserveMivRejQty { get; set; }
        public decimal? DelMivRejQty { get; set; }
        public int? IssuedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? IssuedDate { get; set; }
        public int? ApprovedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ApprovedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DelDate { get; set; }
        public string Remark { get; set; }
        public string MRCNO { get; set; }
        public string MIVPDF { get; set; }
        [ForeignKey(nameof(LocItemID))]
        public virtual LocItem LocItem { get; set; }
        [ForeignKey(nameof(CompanyID))]
        public virtual Company Company { get; set; }
    }
}
