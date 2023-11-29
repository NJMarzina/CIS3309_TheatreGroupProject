using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class Movie
    {
        public string Title;
        public enum Genre { Horror, Thriller, History, Action, Romance, Comedy}
        public Genre genre;
        public string Img;
        public string rating;
        public string Director;
        public string description;
    }
}
