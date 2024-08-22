using System;

namespace AWMS.dto
{
    public class LocItemBalanceDto
    {
        public int ItemId { get; set; }
        public int LocItemID { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public string PL { get; set; }
        public string Po { get; set; }
        public string PK { get; set; }
        public string Discipline { get; set; }
        public string BatchNo { get; set; }
        public string HeatNo { get; set; }
        public int Location { get; set; }
        public decimal QtyinLoc { get; set; }
        public int UnitID { get; set; }
        public string Scope { get; set; }
        public decimal QtyIssue { get; set; }
    }
}
