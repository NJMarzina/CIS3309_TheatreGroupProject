using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class Show
    {
        public TheaterRoom TheaterRoom { get; set; }
        public string MovieTitle { get; set; }
        public TimeSlot ShowTime { get; set; }
        public enum TimeSlot
        {
            SLOT_0800_1130,
            SLOT_1130_1500,
            SLOT_1500_1830,
            SLOT_1830_2200
        }


        public Show(TheaterRoom theaterRoom, string movieTitle, TimeSlot showTime){
            this.TheaterRoom = theaterRoom;
            this.MovieTitle = movieTitle;
            this.ShowTime = showTime;
        }
    }
}
