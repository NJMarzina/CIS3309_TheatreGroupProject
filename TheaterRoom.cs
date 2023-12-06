using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_TheatreGroupProject
{
    class TheaterRoom
    {
        public enum SeatStatus { open, full }
        public string room { get; set; }
        public Dictionary<string, SeatStatus> seatChart;


        public TheaterRoom(String room)
        {
            this.room = room;
            seatChart = new Dictionary<string, SeatStatus>();
            for (int i = 97; i <= 100; i++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    string key = Convert.ToChar(i).ToString() + z.ToString();
                    seatChart.Add(key, SeatStatus.open);
                }
            }
        }




        public SeatStatus changeSeatStatus(string seat)
        {

            if (seatChart.ContainsKey(seat))
            {

                return seatChart[seat];
            }
            else
            {
                throw new Exception("No seat with that name");

            }


        }



    }


}
