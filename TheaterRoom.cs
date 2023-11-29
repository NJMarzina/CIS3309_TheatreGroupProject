using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class TheaterRoom
    {
        public enum SeatStatus { open, full }
        public string room { get; set; }
        public Dictionary<string, SeatStatus> seatChart = new Dictionary<string, SeatStatus>();

        
        public TheaterRoom(String room) {
            this.room = room;

            for (int i = 0; i < 5; i++)
            {

                for (int z = 0; z < 10; i++)
                {
                    string key = Convert.ToChar(i).ToString();
                    key += z.ToString();
                    seatChart.Add(key, SeatStatus.open);
                }
            }
        }

        public void changeSeatStatus(string seat)
        {
            //
        }

    }

    
}
