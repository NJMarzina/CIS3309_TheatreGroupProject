using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_TheatreGroupProject
{
    public partial class frmMain : Form
    {
        String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataReader myReader;
        OleDbDataAdapter myAdapter;
        DataTable employeeTable;

        bool signedIn = false;

        public frmMain()
        {
            InitializeComponent();
        }

        public void btnEmployeeSignin_Click(object sender, EventArgs e)
        {
            //frmEmployeeSignin signin = new frmEmployeeSignin();

            //signin.Show();
        }

        public void btnView_Click(object sender, EventArgs e)
        {
            frmMovieView viewMovies = new frmMovieView();

            viewMovies.Show();

            //redirect to form that shows all movies playing
            //redirect from movie playing into seat selection
            //from seat selected into checkout
        }

        public void btnViewShows_Click(object sender, EventArgs e)
        {

        }
    }
}
