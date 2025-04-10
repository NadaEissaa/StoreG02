using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.FIFA
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public void Run(Ball ball)
        {
            Console.WriteLine($"Player : {Name} is Running at {ball}");
        }
        public override string ToString()
        {
            return $"{Name } , {TeamName}";
        }
    }
}
