using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.datalayer.Entities
{
    public class PackingList
    {
        public PackingList()
        {
            
        }
        [Key]
        public int PLId { get; set; }
        public int? ShId { get; set; }
        public int? MrId { get; set; }
        public int? PoId { get; set; }
        public int? IrnId { get; set; }
        [Required]
        [MaxLength(300)]
        public string PLName { get; set; }
        [MaxLength(50)]
        public string? ArchiveNO { get; set; }
        [MaxLength(50)]
        public string? PLNO { get; set; }
        [MaxLength(50)]
        public string? OPINO { get; set; }
        [MaxLength(50)]
        public string? Project { get; set; }
        public int? AreaUnitID { get; set; }
        public int? SupplierId { get; set; }
        public int? DesciplineId { get; set; }
        public int? VendorId { get; set; }
        public int? DescriptionForPkId { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public string? Volume { get; set; }
        public string? Vessel { get; set; }
        public int? EnteredBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EnteredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? MARDate { get; set; }
        public string? Remark { get; set; }
        public int? LocalForeign { get; set; }
        public string? RTINO { get; set; }
        public string? InvoiceNO { get; set; }
        public string? IRCNO { get; set; }
        public string? LCNO { get; set; }
        public string? BLNO { get; set; }
        public string? Remarkcustoms { get; set; }
        public int? EditedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; private set; }
        public string? PLDPF { get; set; }
        public bool? Balance { get; set; }
        public bool? Attachment { get; set; }
        public bool? SitePL { get; set; }
      
        public virtual Mr Mr { get; set; }
        public virtual Po Po { get; set; }
        public virtual Shipment Shipment { get; set; }
        public virtual AreaUnit AreaUnit { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Descipline Descipline { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Irn Irn { get; set; }
        public virtual DescriptionForPk DescriptionForPk { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
    }
}
