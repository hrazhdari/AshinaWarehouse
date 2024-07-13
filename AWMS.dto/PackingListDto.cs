namespace AWMS.dto
{
    public class PackingListDto
    {
        public int PLId { get; set; }
        public int? ShId { get; set; }
        public int? MrId { get; set; }
        public int? PoId { get; set; }
        public int? IrnId { get; set; }
        public string PLName { get; set; }
        public string? ArchiveNO { get; set; }
        public string? PLNO { get; set; }
        public string? OPINO { get; set; }
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
        public DateTime? EnteredDate { get; set; }
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
        public DateTime? EditedDate { get; private set; }
        public string? PLDPF { get; set; }
        public bool? Balance { get; set; }
        public bool? Attachment { get; set; }
        public bool? SitePL { get; set; }
    }
}
