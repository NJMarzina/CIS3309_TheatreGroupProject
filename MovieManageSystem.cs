using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CIS3309_TheatreGroupProject
{
    class MovieManageSystem
    {
        public static OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Movies.accdb");


        public static DataTable LoadMoiveDB()
        {
            
            OleDbDataAdapter myDataAdapter;
            DataSet movieDataSet;
            DataTable movieTable;
           
            string strSQL;


            strSQL = "SELECT * FROM MoviesTable";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            movieDataSet = new DataSet("MoviesTable");
            myDataAdapter.Fill(movieDataSet, "MovieTable");

            movieTable = movieDataSet.Tables["MovieTable"];
            
            return movieTable;

        }
   
        /// /////////////////////////////////////////  INSERT  ///////////////////////////////////////////////////////////////
        public static void InsertMovieDB(Movie movie)
        {
       
            // SQL STATMENT
            string strSQL = "INSERT INTO MoviesTable (Title, Genre, Director, Rating, Description, Img)" +
            " VALUES ('" + movie.Title + "','" + movie.MovieGenre + "','" + movie.Director + "','" + movie.Rating + "','" +
            movie.Description + "','" + movie.Img + "');";

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


        public static void DeleteMovieDB(string title)
        {
            string strSQL = "DELETE FROM MoviesTable WHERE Title ='" + title + "'";
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

        public static void UpdateDB(string title, string columnName, object newValue)
        {
            myConnection.Open();
            string strSQL = $"UPDATE MoviesTable SET {columnName} = ? WHERE Title = ?";
           

                

                using (OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection))
                {

                 myCommand.Parameters.AddWithValue("@newValue", newValue);
                 myCommand.Parameters.AddWithValue("@name", title);


                 myCommand.ExecuteNonQuery();
                }
            myConnection.Close();
         }

        public static DataTable FilterMovieGenreDB(String itemType)
        {
            string strSQL = "SELECT * FROM MoivesTable WHERE Genre = '" + itemType + "'";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet movieDataSet = new DataSet("MoivesTable");
            myDataAdapter.Fill(movieDataSet, "MoviesTable");

            DataTable filteredMovieTable = movieDataSet.Tables["ItemTable"];
            return filteredMovieTable;

        }


    }
}
