using FinalProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   static class Session
    {
        static Session()
        {
                
        }

        public static UsersData Data { get;  set; }

        public static User User { get; set; }
        public static MainForm MainForm { get;  set; }
        public static UserPageForm UserPage { get;  set; }
        public static AdminForm AdminForm { get;  set; }
    }
}
