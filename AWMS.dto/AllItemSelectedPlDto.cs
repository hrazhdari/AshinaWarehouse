using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.dto
{
    public class AllItemSelectedPlDto
    {
        public int PKID { get; set; }
        public int PLId { get; set; }
        public string PK { get; set; }
        public int LocItemID { get; set; }
        public int LocationID { get; set; }
        public decimal Qty { get; set; }
        public decimal OverQty { get; set; }
        public decimal ShortageQty { get; set; }
        public decimal DamageQty { get; set; }
        public decimal RejectQty { get; set; }
        public decimal NISQty { get; set; }
        public int ItemId { get; set; }
        public int? ItemOfPk { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public int UnitID { get; set; }
        public decimal QtyPL { get; set; } // Changed to avoid name conflict
        public decimal OverQtyPL { get; set; } // Changed to avoid name conflict
        public decimal ShortageQtyPL { get; set; } // Changed to avoid name conflict
        public decimal DamageQtyPL { get; set; } // Changed to avoid name conflict
        public decimal? IncorectQty { get; set; } // Corrected property name
        public int ScopeID { get; set; }
        public string Remark { get; set; }
        public bool? Hold { get; set; }
        public decimal? NIS { get; set; }
        public decimal? NetW { get; set; }
        public decimal? GrossW { get; set; }
        public string HeatNo { get; set; }
        public string BatchNo { get; set; }
        public string StorageCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }
        public string MSRNO { get; set; }
        public string MSRPDF { get; set; }
    }
}


