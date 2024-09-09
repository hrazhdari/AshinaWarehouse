using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.dto
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public int? PKID { get; set; }
        public int? ItemOfPk { get; set; }
        public string? Tag { get; set; }
        public string? Description { get; set; }
        public int? UnitID { get; set; }
        public decimal? Qty { get; set; }
        public decimal? OverQty { get; set; }
        public decimal? ShortageQty { get; set; }
        public decimal? DamageQty { get; set; }
        public decimal? IncorectQty { get; set; }
        public int? ScopeID { get; set; }
        public string? HeatNo { get; set; }
        public string? BatchNo { get; set; }
        public string? Remark { get; set; }
        public string? MTRNo { get; set; }
        public string? ColorCode { get; set; }
        public string? LabelNo { get; set; }
        public int? EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public decimal? Price { get; set; }
        public int? UnitPriceID { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public int? ItemCodeId { get; set; }
        public string? BaseMaterial { get; set; }
        public bool? Hold { get; set; }
        public decimal? NIS { get; set; }
        public string? StorageCode { get; set; }

    }
}
