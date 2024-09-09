using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.dto
{
    public class MaterialIssueVoucherDto
    {
        public DateTime? ArrivalDate { get; set; }
        public string Project { get; set; }
        public int PoId { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public string PLName { get; set; }
        public int PK { get; set; }
        public string ItemOfPk { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public decimal QtyPL { get; set; } // مقدار Qty در بسته‌بندی‌ها
        public decimal QtyInLoc { get; set; } // مقدار Qty در LocItems
        public decimal Balance { get; set; }
        public decimal Inventory { get; set; }
        public int DisciplineId { get; set; }
        public int ScopeId { get; set; }
        public string HeatNo { get; set; }
        public string BatchNo { get; set; }
        public string Remark { get; set; }
        public bool Hold { get; set; }
    }

}
