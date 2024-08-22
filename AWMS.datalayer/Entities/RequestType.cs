using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AWMS.datalayer.Entities
{
    public class RequestType
    {
        public RequestType()
        {
            
        }

        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }

        // رابطه یک به چند با Request
        public virtual ICollection<Request> Requests { get; set; }
    }
}
