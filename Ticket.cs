using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    public class Ticket
    {
        //seat
        //movie
        //theatre room
        //time
        //price

        enum SeatStatus { open, full };
        Dictionary<String, SeatStatus> seatChart;
        Movie movie;
        TheaterRoom theatreRoom;
        enum TimeSlot { SLOT_0800_1130, SLOT_1130_1500, SLOT_1500_1830, SLOT_1830_2200};
        double price;

        public Ticket()
        {

        }

        public Ticket(double price)
        {
            this.price = price;
        }

        public Ticket(Movie m, TheaterRoom theater, int price)
        {

        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
    }
}
