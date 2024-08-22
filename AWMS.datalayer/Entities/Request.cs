using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class Request
    {
        public Request()
        {

        }

        [Key]
        public int ReqLocItemID { get; set; }
        public int? LocItemID { get; set; }
        public int? CompanyID { get; set; }
        public int? CompanyID2 { get; set; }
        public int? ContractId { get; set; }
        public int? ContractId2 { get; set; }
        public int? AreaUnitID { get; set; }
        public int? VendorID { get; set; }
        public int? TypeID { get; set; }
        public string RequestNO { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReqDate { get; set; }
        public int? Item { get; set; }
        public decimal? ReqMivQty { get; set; }
        public decimal? ReserveMivQty { get; set; }
        public decimal? DelMivQty { get; set; }
        public decimal? ReqMivRejQty { get; set; }
        public decimal? ReserveMivRejQty { get; set; }
        public decimal? DelMivRejQty { get; set; }
        public decimal? ReqMrvQty { get; set; }
        public decimal? DelMrvQty { get; set; }
        public decimal? DelMrvRejQty { get; set; }
        public decimal? ReqHmvQty { get; set; }
        public decimal? DelHmvQty { get; set; }
        public decimal? DelHmvRejQty { get; set; }
        public int? IssuedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? IssuedDate { get; set; }
        public int? ApprovedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ApprovedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DelDate { get; set; }
        public string? Remark { get; set; }
        public string? MRCNO { get; set; }
        public string? MRVNO { get; set; }
        public string? HMVNO { get; set; }
        public string? RequestPDF { get; set; }

        [ForeignKey(nameof(LocItemID))]
        public virtual LocItem LocItem { get; set; }

        //[ForeignKey(nameof(CompanyID))]
        //public virtual Company Company { get; set; }

        //[ForeignKey(nameof(CompanyID2))]
        //public virtual Company Company2 { get; set; }

        //[ForeignKey(nameof(ContractId))]
        //public virtual CompanyContract CompanyContract { get; set; }

        //[ForeignKey(nameof(ContractId2))]
        //public virtual CompanyContract CompanyContract2 { get; set; }

        //[ForeignKey(nameof(AreaUnitID))]
        //public virtual AreaUnit AreaUnit { get; set; }  // تعریف رابطه با AreaUnit

        //[ForeignKey(nameof(VendorID))]
        //public virtual Vendor Vendor { get; set; }  // تعریف رابطه با Vendor
    }
}
