using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int Id { get; set; }
        public string u_name { get; set; }
        public Nullable<int> u_phone { get; set; }
        public string u_address { get; set; }
        public string u_image { get; set; }
        public string u_email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
