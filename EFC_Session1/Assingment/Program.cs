using Assingment.Context;
using Microsoft.EntityFrameworkCore;

namespace Assingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
        }
    }
}
