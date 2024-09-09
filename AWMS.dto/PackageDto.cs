
namespace AWMS.dto
{
    public class PackageDto
    {
        public int PKID { get; set; }
        public int PLId { get; set; }
        public int PK { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public string? Dimension { get; set; }
        public string? Volume { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string? Desciption { get; set; }
        public string? Remark { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public string? MSRNO { get; set; }
        public string? MSRPDF { get; set; }
        public DateTime? MSRDate { get; set; }
        public int? MSREnteredBy { get; set; }
        public bool? MSRStatus { get; set; }
        public int? MSRRev { get; set; }
        public int? MSRRevEnteredBy { get; set; }
        public DateTime? MSRRevDate { get; set; }
    }
}
