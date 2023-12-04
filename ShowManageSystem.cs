using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            showDataSet = new DataSet("MoviesTable");
            myDataAdapter.Fill(showDataSet, "ShowTable");

            showTable = showDataSet.Tables["ShowTable"];

            return showTable;

        }

        /// /////////////////////////////////////////  INSERT  ///////////////////////////////////////////////////////////////
        public static void InsertShowDB(Show show)
        {

            // SQL STATMENT
           // string strSQL = "INSERT INTO ShowsTable (Title, Genre, Director, Rating, Description, Img)" +
            //w" VALUES ('" + movie.Title + "','" + movie.MovieGenre + "','" + movie.Director + "','" + movie.Rating + "','" +
            //movie.Description + "','" + movie.Img + "');";

           // OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();
                //insertCommand.ExecuteNonQuery();
            }
            finally
            {
                myConnection.Close();
            }

        }






        //////////////////////////////////////////////  DELETE  ///////////////////////////////////////


        public static void DeleteShowDB(string title)
        {
            string strSQL = "DELETE FROM ShowsTable WHERE Moive ='" + title + "'";
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

        public static DataTable FilterShowMoiveDB(String movie)
        {
            string strSQL = "SELECT * FROM ShowsTable WHERE Genre = '" + movie + "'";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet movieDataSet = new DataSet("MoivesTable");
            myDataAdapter.Fill(movieDataSet, "MoviesTable");

            DataTable filteredMovieTable = movieDataSet.Tables["ItemTable"];
            return filteredMovieTable;
        }
    }
}
    
