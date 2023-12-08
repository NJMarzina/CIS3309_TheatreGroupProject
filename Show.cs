using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    public class Show
    {
        public TheaterRoom TheaterRoom { get; set; }
        public string MovieTitle { get; set; }
        public TimeSlot ShowTime { get; set; }

        public DateTime ShowDay;
        public enum TimeSlot
        {
            SLOT_0800_1130,
            SLOT_1130_1500,
            SLOT_1500_1830,
            SLOT_1830_2200
        }

        public Show()
        {

        }

        public Show(TheaterRoom theaterRoom, string movieTitle, DateTime showDay, TimeSlot showTime){
            this.TheaterRoom = theaterRoom;
            this.MovieTitle = movieTitle;
            this.ShowDay = showDay;
            this.ShowTime = showTime;
        }

        public Show(TheaterRoom theaterRoom, string movieTitle, TimeSlot showTime,
                string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10,
                string b1, string b2, string b3, string b4, string b5, string b6, string b7, string b8, string b9, string b10,
                string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9, string c10,
                string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10)
        {
            TheaterRoom.SeatStatus status;

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a1, out status))
            {
                theaterRoom.seatChart["a1"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a2, out status))
            {
                theaterRoom.seatChart["a2"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a3, out status))
            {
                theaterRoom.seatChart["a3"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a4, out status))
            {
                theaterRoom.seatChart["a4"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a5, out status))
            {
                theaterRoom.seatChart["a5"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a6, out status))
            {
                theaterRoom.seatChart["a6"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a7, out status))
            {
                theaterRoom.seatChart["a7"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a8, out status))
            {
                theaterRoom.seatChart["a8"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a9, out status))
            {
                theaterRoom.seatChart["a9"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(a10, out status))
            {
                theaterRoom.seatChart["a10"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b1, out status))
            {
                theaterRoom.seatChart["b1"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b2, out status))
            {
                theaterRoom.seatChart["b2"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b3, out status))
            {
                theaterRoom.seatChart["b3"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b4, out status))
            {
                theaterRoom.seatChart["b4"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b5, out status))
            {
                theaterRoom.seatChart["b5"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b6, out status))
            {
                theaterRoom.seatChart["b6"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b7, out status))
            {
                theaterRoom.seatChart["b7"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b8, out status))
            {
                theaterRoom.seatChart["b8"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b9, out status))
            {
                theaterRoom.seatChart["b9"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(b10, out status))
            {
                theaterRoom.seatChart["b10"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c1, out status))
            {
                theaterRoom.seatChart["c1"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c2, out status))
            {
                theaterRoom.seatChart["c2"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c3, out status))
            {
                theaterRoom.seatChart["c3"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c4, out status))
            {
                theaterRoom.seatChart["c4"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c5, out status))
            {
                theaterRoom.seatChart["c5"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c6, out status))
            {
                theaterRoom.seatChart["c6"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c7, out status))
            {
                theaterRoom.seatChart["c7"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c8, out status))
            {
                theaterRoom.seatChart["c8"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c9, out status))
            {
                theaterRoom.seatChart["c9"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(c10, out status))
            {
                theaterRoom.seatChart["c10"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d1, out status))
            {
                theaterRoom.seatChart["d1"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d2, out status))
            {
                theaterRoom.seatChart["d2"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d3, out status))
            {
                theaterRoom.seatChart["d3"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d4, out status))
            {
                theaterRoom.seatChart["d4"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d5, out status))
            {
                theaterRoom.seatChart["d5"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d6, out status))
            {
                theaterRoom.seatChart["d6"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d7, out status))
            {
                theaterRoom.seatChart["d7"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d8, out status))
            {
                theaterRoom.seatChart["d8"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d9, out status))
            {
                theaterRoom.seatChart["d9"] = status;
            }

            if (Enum.TryParse<TheaterRoom.SeatStatus>(d10, out status))
            {
                theaterRoom.seatChart["d10"] = status;
            }
        }

        public static Array GetTimeSlotArray()
        {
            Array array = Enum.GetValues(typeof(TimeSlot));
            return array;
        }

        public void UpdateShow(List<String>seats, String movie, String timeSlot)
        {
            OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shows.accdb");

            for (int x = 0; x < 40; x++)    //update for all a1-a10, b1-b10, c1-c10, d1-d10
            {
                if (seats.Contains("a1"))
                {
                    string strSQL = "UPDATE ShowsTable SET a1 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a2"))
                {
                    string strSQL = "UPDATE ShowsTable SET a2 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a3"))
                {
                    string strSQL = "UPDATE ShowsTable SET a3 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a4"))
                {
                    string strSQL = "UPDATE ShowsTable SET a4 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a5"))
                {
                    string strSQL = "UPDATE ShowsTable SET a5 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a6"))
                {
                    string strSQL = "UPDATE ShowsTable SET a6 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a7"))
                {
                    string strSQL = "UPDATE ShowsTable SET a7 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a8"))
                {
                    string strSQL = "UPDATE ShowsTable SET a8 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a9"))
                {
                    string strSQL = "UPDATE ShowsTable SET a9 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("a10"))
                {
                    string strSQL = "UPDATE ShowsTable SET a10 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (seats.Contains("b1"))
                {
                    string strSQL = "UPDATE ShowsTable SET b1 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b2"))
                {
                    string strSQL = "UPDATE ShowsTable SET b2 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b3"))
                {
                    string strSQL = "UPDATE ShowsTable SET b3 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b4"))
                {
                    string strSQL = "UPDATE ShowsTable SET b4 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b5"))
                {
                    string strSQL = "UPDATE ShowsTable SET b5 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b6"))
                {
                    string strSQL = "UPDATE ShowsTable SET b6 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b7"))
                {
                    string strSQL = "UPDATE ShowsTable SET b7 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b8"))
                {
                    string strSQL = "UPDATE ShowsTable SET b8 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b9"))
                {
                    string strSQL = "UPDATE ShowsTable SET b9 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("b10"))
                {
                    string strSQL = "UPDATE ShowsTable SET b10 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (seats.Contains("c1"))
                {
                    string strSQL = "UPDATE ShowsTable SET c1 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c2"))
                {
                    string strSQL = "UPDATE ShowsTable SET c2 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c3"))
                {
                    string strSQL = "UPDATE ShowsTable SET c3 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c4"))
                {
                    string strSQL = "UPDATE ShowsTable SET c4 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c5"))
                {
                    string strSQL = "UPDATE ShowsTable SET c5 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c6"))
                {
                    string strSQL = "UPDATE ShowsTable SET c6 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c7"))
                {
                    string strSQL = "UPDATE ShowsTable SET c7 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c8"))
                {
                    string strSQL = "UPDATE ShowsTable SET c8 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c9"))
                {
                    string strSQL = "UPDATE ShowsTable SET c9 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("c10"))
                {
                    string strSQL = "UPDATE ShowsTable SET c10 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (seats.Contains("d1"))
                {
                    string strSQL = "UPDATE ShowsTable SET d1 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d2"))
                {
                    string strSQL = "UPDATE ShowsTable SET d2 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d3"))
                {
                    string strSQL = "UPDATE ShowsTable SET d3 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d4"))
                {
                    string strSQL = "UPDATE ShowsTable SET d4 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d5"))
                {
                    string strSQL = "UPDATE ShowsTable SET d5 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d6"))
                {
                    string strSQL = "UPDATE ShowsTable SET d6 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d7"))
                {
                    string strSQL = "UPDATE ShowsTable SET d7 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d8"))
                {
                    string strSQL = "UPDATE ShowsTable SET d8 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d9"))
                {
                    string strSQL = "UPDATE ShowsTable SET d9 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
                if (seats.Contains("d10"))
                {
                    string strSQL = "UPDATE ShowsTable SET d10 = 'full' WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

                    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
            }
        }
    }
}
