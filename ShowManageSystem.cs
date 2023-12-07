using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_TheatreGroupProject
{
    class ShowManageSystem
    {

        public static OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shows.accdb");
        public static string title;
        /// <summary>
        /// ///////////////////////////////////   SHOW DB /////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadShowsDB()
        {

            OleDbDataAdapter myDataAdapter;
            DataSet showDataSet;
            DataTable showTable;

            string strSQL;


            strSQL = "SELECT * FROM ShowsTable";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowTable");
            myDataAdapter.Fill(showDataSet, "ShowTable");

            showTable = showDataSet.Tables["ShowTable"];

            return showTable;

        }

        /// /////////////////////////////////////////  INSERT  ///////////////////////////////////////////////////////////////
        public static void InsertShowDB(Show show)
        {

            // SQL STATMENT
            string strSQL = "INSERT INTO ShowsTable ( Room, Movie, ShowDay, ShowTime, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, " +
                "c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10)" +
                " VALUES ('" + show.TheaterRoom.room + "', '" + show.MovieTitle + "', '" + show.ShowDay + "', '" + show.ShowTime + "', '" + show.TheaterRoom.seatChart["a1"] + "','" + show.TheaterRoom.seatChart["a2"] +
                "','" + show.TheaterRoom.seatChart["a3"] + "','" + show.TheaterRoom.seatChart["a4"] + "','" + show.TheaterRoom.seatChart["a5"] + "','" + show.TheaterRoom.seatChart["a6"] +
                "','" + show.TheaterRoom.seatChart["a7"] + "','" + show.TheaterRoom.seatChart["a8"] + "','" + show.TheaterRoom.seatChart["a9"] + "','" + show.TheaterRoom.seatChart["a10"] +
                "','" + show.TheaterRoom.seatChart["b1"] + "','" + show.TheaterRoom.seatChart["b2"] + "','" + show.TheaterRoom.seatChart["b3"] + "','" + show.TheaterRoom.seatChart["b4"] +
                "','" + show.TheaterRoom.seatChart["b5"] + "','" + show.TheaterRoom.seatChart["b6"] + "','" + show.TheaterRoom.seatChart["b7"] + "','" + show.TheaterRoom.seatChart["b8"] +
                "','" + show.TheaterRoom.seatChart["b9"] + "','" + show.TheaterRoom.seatChart["b10"] + "','" + show.TheaterRoom.seatChart["c1"] + "','" + show.TheaterRoom.seatChart["c2"] +
                "','" + show.TheaterRoom.seatChart["c3"] + "','" + show.TheaterRoom.seatChart["c4"] + "','" + show.TheaterRoom.seatChart["c5"] + "','" + show.TheaterRoom.seatChart["c6"] +
                "','" + show.TheaterRoom.seatChart["c7"] + "','" + show.TheaterRoom.seatChart["c8"] + "','" + show.TheaterRoom.seatChart["c9"] + "','" + show.TheaterRoom.seatChart["c10"] +
                "','" + show.TheaterRoom.seatChart["d1"] + "','" + show.TheaterRoom.seatChart["d2"] + "','" + show.TheaterRoom.seatChart["d3"] + "','" + show.TheaterRoom.seatChart["d4"] +
                "','" + show.TheaterRoom.seatChart["d5"] + "','" + show.TheaterRoom.seatChart["d6"] + "','" + show.TheaterRoom.seatChart["d7"] + "','" + show.TheaterRoom.seatChart["d8"] +
                "','" + show.TheaterRoom.seatChart["d9"] + "','" + show.TheaterRoom.seatChart["d10"] + "');";


            OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
            finally
            {
                myConnection.Close();
            }

        }






        //////////////////////////////////////////////  DELETE  ///////////////////////////////////////


        public static void DeleteShowDB(string num)
        {
            string strSQL = "DELETE FROM ShowsTable WHERE Show ='" + num + "'";
            OleDbCommand deleteCommand = new OleDbCommand(strSQL, myConnection);
            try
            {
                myConnection.Open();
                deleteCommand.ExecuteNonQuery();

            }
            finally
            {
                myConnection.Close();
            }

        }

        public static void UpdateShowDB(string title, string columnName, object newValue)
        {
            myConnection.Open();
            string strSQL = $"UPDATE ShowsTable SET {columnName} = ? WHERE Title = ?";




            using (OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection))
            {

                myCommand.Parameters.AddWithValue("@newValue", newValue);
                myCommand.Parameters.AddWithValue("@name", title);


                myCommand.ExecuteNonQuery();
            }
            myConnection.Close();
        }


        /// <summary>
        /// /////////////////////////////////////////////////// FILTER STATMENTS ////////////////////////////////////////////////
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static DataTable FilterShowMovieDB(String movie)
        {
            string strSQL = "SELECT * FROM ShowsTable WHERE Movie = '" + movie + "'";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable filteredShowTable = showDataSet.Tables["ShowsTable"];
            return filteredShowTable;
        }

        public static DataTable FilterShowTimeDB(String time)
        {
            time = time.ToString();
            string strSQL = "SELECT * FROM ShowsTable WHERE ShowTime = '" + time + "'";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable filteredShowTable = showDataSet.Tables["ShowTable"];
            return filteredShowTable;
        }

        ///////////////////// METHOD THE GETS THE SHOW DAYS OF A CERTAIN MOVIE AND PUTS THEM IN A LIST OR ARRAY
        public static Array GetShowDayDB(String movieTitle)
        {
            string strSQL = "SELECT ShowDay FROM ShowsTable WHERE Movie = '" + movieTitle + "'";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable DaysShowTable = showDataSet.Tables["ShowTable"];

            if (DaysShowTable == null)
            {
                MessageBox.Show("No available show day for this movie");
                return null;
            }
            else
            {
                return GetShowDayArray(DaysShowTable);
            }
        }

   
        public static Array GetShowDayArray(DataTable table)
        {
            string[] days = new string[table.Rows.Count];

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    string day = row["ShowDay"].ToString();
                    days[i] = day;
                }
                days.ToArray<string>();
                return days;
            }
            else
            {
                MessageBox.Show("Error in GetShowDayArray: No rows in the table.");
                return null;
            }
        }


        ////////////////// METHOD THAT GETS SHOW TIMES FROM MOVIE AND SHOW DAY
    }
}

