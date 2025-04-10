using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV4.YouTube
{
    internal class Channel
    {
        public string Title { get; set; }
        public List<Video> videos { get; set; } = new List<Video>();
        
        public void AddVides(Video videos)
        {
            Uploaded.Add(videos);
           
        }

        public Action<Video> Uploaded;

    }
}
