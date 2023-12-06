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

        public List<object> seats = new List<object>();

        public Show(TheaterRoom theaterRoom, string movieTitle, TimeSlot showTime){
            this.TheaterRoom = theaterRoom;
            this.MovieTitle = movieTitle;
            this.ShowTime = showTime;
        }

        public Show(TheaterRoom theaterRoom, string movieTitle, TimeSlot showTime,
                string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10,
                string b1, string b2, string b3, string b4, string b5, string b6, string b7, string b8, string b9, string b10,
                string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9, string c10,
                string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10)
        {
            seats.Add(theaterRoom);
            seats.Add(movieTitle);
            seats.Add(showTime);
            seats.AddRange(new[]
            {
                a1, a2, a3, a4, a5, a6, a7, a8, a9, a10,
                b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
                c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,
                d1, d2, d3, d4, d5, d6, d7, d8, d9, d10
            });
        }

        public static Array GetTimeSlotArray()
        {
            Array array = Enum.GetValues(typeof(TimeSlot));
            return array;
        }

        public List<object>Seats
        {
            get
            {
                return this.seats;
            }
        }
    }
}
