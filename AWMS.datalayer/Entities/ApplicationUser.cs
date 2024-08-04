using System;

namespace AWMS.datalayer.Entities
{
    public class ApplicationUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleID { get; set; } // کلید خارجی به جدول نقش‌ها

        // خصوصیات اضافی برای دسترسی به نقش (اختیاری)
        public ApplicationRole ApplicationRole { get; set; }

        public ApplicationUser() { }

        public ApplicationUser(int userID, string username, string passwordHash, int roleID)
        {
            UserID = userID;
            Username = username;
            PasswordHash = passwordHash;
            RoleID = roleID;
        }
    }
}
