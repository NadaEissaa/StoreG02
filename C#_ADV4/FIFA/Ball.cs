using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.FIFA
{
    internal class Ball
    {
        public int Id { get; set; }

        public List<Player> Players { get; set; }
        public List<Player> Referee { get; set; }


        public Locationcs location
        {
            get
            {
                return location;

            }
            set
            {
                location = value;
                foreach (var item in Players)
                {
                    item.Run(this);
                }
                foreach(var item in Referee)
                {
                    item.Look(this);
                }
         
            }
        }
        public override string ToString()
        {
            return $"{location} , {Id}";
        }
    }
}
