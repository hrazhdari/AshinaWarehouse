namespace AWMS.dto
{
    public class PoDto
    {
        public int PoId { get; set; }
        public int? MrId { get; set; }
        public string PoName { get; set; }
        public string? PoDescription { get; set; }
        public DateTime? EnteredDate { get; set; }
    }
}
