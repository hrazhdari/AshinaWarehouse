using System;

namespace AWMS.datalayer.Entities
{
    public class ApplicationRole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public ApplicationRole() { }

        public ApplicationRole(int roleID, string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }
    }
}
