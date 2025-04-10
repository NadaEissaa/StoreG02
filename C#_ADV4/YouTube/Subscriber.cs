using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.YouTube
{
    internal class Subscriber
    {
        public string Name { get; set; }

        public void Notify()
        {
            Console.WriteLine("Channel");
        }
        public override string ToString()
        {
            return $"Subscriber Name : {Name}";
        }
    }
}
