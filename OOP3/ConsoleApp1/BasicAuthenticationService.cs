using ConsoleApp1.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
        {

            {"Nada Eissa" , "1234" },
            {"Ahmed Eissa" , "1245" }

        };

        private Dictionary<string, string> roles = new Dictionary<string, string>
        {
            {"Nada Eissa" , "Admin" },
            {"Ahmed Eissa" , "User" }
        };

        public bool AuthenticateUser(string Username, string Password)
        {
            return users.ContainsKey(Username) && users[Username] == Password;

        }

        public bool AuthorizeUser(string Username, string Role)
        {
            return roles.ContainsKey(Username) && roles[Username] == Role;
        }

    }
}
