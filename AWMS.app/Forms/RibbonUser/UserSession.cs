using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.app.Forms.RibbonUser 
{ 
    public class UserSession
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int RoleID { get; set; }
    }
    public static class SessionManager
    {
        private static readonly Dictionary<int, UserSession> _sessions = new();

        public static void AddSession(int userId, UserSession session)
        {
            _sessions[userId] = session;
        }

        public static UserSession GetSession(int userId)
        {
            return _sessions.ContainsKey(userId) ? _sessions[userId] : null;
        }
        public static void RemoveSession(int userId)
        {
            _sessions.Remove(userId);
        }
    }

}
