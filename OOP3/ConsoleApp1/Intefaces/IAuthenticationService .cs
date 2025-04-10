using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Intefaces
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string Username, string Password);
        bool AuthorizeUser(string Username, string Role);

    }
}
