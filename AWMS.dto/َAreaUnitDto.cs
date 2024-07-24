using System.ComponentModel.DataAnnotations;

namespace AWMS.dto
{
    public class AreaUnitDto
    {
        public int AreaUnitID { get; set; }
        public string AreaUnitName { get; set; }
        public string? AreaUnitDescription { get; set; }
        public string? AreaUnitTrain { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string? Remark { get; set; }

    }
}
