using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.FIFA
{
    internal class Referee
    {
        public string Name { get; set; }
        public void Look(Ball ball)
        {
            Console.WriteLine($"{Name} is looking at the ball");
        }
        public override string ToString()
        {
            return $" Referee Name {Name}");
        }
    }
}
