using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class Movie
    {
        public string Title { get; set; }
        public enum Genre { Horror, Thriller, History, Action, Romance, Comedy }
        public Genre genre { get; set; }
        public string Img { get; set; }
        public string rating { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }


        public Movie(string title, Genre genre, string img, string rating, string director, string description)
        {
            Title = title;
            MovieGenre = genre;
            Img = img;
            Rating = rating;
            Director = director;
            Description = description;
        }
    }

    
}

