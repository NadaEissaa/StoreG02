using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.YouTube
{
    internal class Video
    {
        public string Title { get; set; }
        public string Desc { get; set; }

        public override string ToString()
        {
            return $"{Title} , {Desc}";
        }
    }
}
