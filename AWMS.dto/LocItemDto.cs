namespace AWMS.dto
{
    public class LocItemDto
    {
        public int LocItemID { get; set; }
        public int LocationID { get; set; }
        public int ItemId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? OverQty { get; set; }
        public decimal? ShortageQty { get; set; }
        public decimal? DamageQty { get; set; }
        public decimal? RejectQty { get; set; }
        public decimal? NISQty { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditedDate { get;  set; }
    }
}