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

        public static DataTable LoadShowDB()
        {
            return null;

        }
       

        /// /////////////////////////////////////////  INSERT  ///////////////////////////////////////////////////////////////
        public static void InsertShowDB(Show show)
        {

            /*
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
            */
        }




        /// //////////////////////////////////////////////////////  DELETE  ///////////////////////////////////////


        public static void DeleteShowDB(string name)
        {
            /*string strSQL = "DELETE FROM MovieTable WHERE Title ='" + name + "'";
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
            */
        }
    }
}
    
