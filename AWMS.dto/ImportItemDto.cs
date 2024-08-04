using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.dto
{
    public class ImportItemDto
    {
        public int? PK { get; set; }
        public string? Tag { get; set; }
        public string? Description { get; set; }
        public string? UnitID { get; set; }
        public decimal? Qty { get; set; }
        public decimal? OverQty { get; set; }
        public decimal? ShortageQty { get; set; }
        public decimal? DamageQty { get; set; }
        public decimal? IncorectQty { get; set; }
        public string? ScopeID { get; set; }
        public string? HeatNo { get; set; }
        public string? BatchNo { get; set; }
        public string? Remark { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public decimal? Price { get; set; }
        public string UnitPriceID { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public string? BaseMaterial { get; set; }

    }
}
