using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class Show
    {
        public TheaterRoom theaterRoom { get; set; }
        public Movie movie { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public Show(){}
    }
}
