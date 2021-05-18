using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        int id;
        string userName;
        string password;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
