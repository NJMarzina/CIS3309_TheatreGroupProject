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
    public partial class frmBuyTickets : Form
    {
        enum TimeSlot { SLOT_0800_1130, SLOT_1130_1500, SLOT_1500_1830, SLOT_1830_2200 };
        public frmBuyTickets()
        {
            InitializeComponent();
            cbxMovies.DataSource = MovieManageSystem.GetMovieTitles();
            cbxTimeSlots.DataSource = CIS3309_TheatreGroupProject.Show.GetTimeSlotArray();

            OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shows.accdb");
    }

        public void frmBuyTickets_Load(object sender, EventArgs e)
        {
            cba1.Hide();
            cba2.Hide();
            cba3.Hide();
            cba4.Hide();
            cba5.Hide();
            cba6.Hide();
            cba7.Hide();
            cba8.Hide();
            cba9.Hide();
            cba10.Hide();
            cbb1.Hide();
            cbb2.Hide();
            cbb3.Hide();
            cbb4.Hide();
            cbb5.Hide();
            cbb6.Hide();
            cbb7.Hide();
            cbb8.Hide();
            cbb9.Hide();
            cbb10.Hide();
            cbc1.Hide();
            cbc2.Hide();
            cbc3.Hide();
            cbc4.Hide();
            cbc5.Hide();
            cbc6.Hide();
            cbc7.Hide();
            cbc8.Hide();
            cbc9.Hide();
            cbc10.Hide();
            cbd1.Hide();
            cbd2.Hide();
            cbd3.Hide();
            cbd4.Hide();
            cbd5.Hide();
            cbd6.Hide();
            cbd7.Hide();
            cbd8.Hide();
            cbd9.Hide();
            cbd10.Hide();
        }

        public void btnAddToCart_Click(object sender, EventArgs e)
        {
            string movie = cbxMovies.SelectedItem.ToString();
            string timeSlot = cbxTimeSlots.SelectedItem.ToString();
            TimeSlot t = TimeSlot.SLOT_0800_1130;
            List<string> seats = new List<string>();
            //Enum.Parse(typeof(TimeSlot), timeSlot);

            if (timeSlot == "SLOT_0800_1130")
                t = TimeSlot.SLOT_0800_1130;
            else if (timeSlot == "SLOT_1130_1500")
                t = TimeSlot.SLOT_1130_1500;
            else if (timeSlot == "SLOT_1500_1830")
                t = TimeSlot.SLOT_1500_1830;
            else if (timeSlot == "SLOT_1830_2200")
                t = TimeSlot.SLOT_1830_2200;

            if (cba1.Checked) seats.Add("a1");
            if (cba2.Checked) seats.Add("a2");
            if (cba3.Checked) seats.Add("a3");
            if (cba4.Checked) seats.Add("a4");
            if (cba5.Checked) seats.Add("a5");
            if (cba6.Checked) seats.Add("a6");
            if (cba7.Checked) seats.Add("a7");
            if (cba8.Checked) seats.Add("a8");
            if (cba9.Checked) seats.Add("a9");
            if (cba10.Checked) seats.Add("a10");
            if (cbb1.Checked) seats.Add("b1");
            if (cbb2.Checked) seats.Add("b2");
            if (cbb3.Checked) seats.Add("b3");
            if (cbb4.Checked) seats.Add("b4");
            if (cbb5.Checked) seats.Add("b5");
            if (cbb6.Checked) seats.Add("b6");
            if (cbb7.Checked) seats.Add("b7");
            if (cbb8.Checked) seats.Add("b8");
            if (cbb9.Checked) seats.Add("b9");
            if (cbb10.Checked) seats.Add("b10");
            if (cbc1.Checked) seats.Add("c1");
            if (cbc2.Checked) seats.Add("c2");
            if (cbc3.Checked) seats.Add("c3");
            if (cbc4.Checked) seats.Add("c4");
            if (cbc5.Checked) seats.Add("c5");
            if (cbc6.Checked) seats.Add("c6");
            if (cbc7.Checked) seats.Add("c7");
            if (cbc8.Checked) seats.Add("c8");
            if (cbc9.Checked) seats.Add("c9");
            if (cbc10.Checked) seats.Add("c10");
            if (cbd1.Checked) seats.Add("d1");
            if (cbd2.Checked) seats.Add("d2");
            if (cbd3.Checked) seats.Add("d3");
            if (cbd4.Checked) seats.Add("d4");
            if (cbd5.Checked) seats.Add("d5");
            if (cbd6.Checked) seats.Add("d6");
            if (cbd7.Checked) seats.Add("d7");
            if (cbd8.Checked) seats.Add("d8");
            if (cbd9.Checked) seats.Add("d9");
            if (cbd10.Checked) seats.Add("d10");

            //movie selected
            //time selected

            //pull info from movie and time
            //iterate through database, if a1==full then cba1==checked...
            //if cba1 becomes checked upon submitting button, then a1=full

            //update sql that if seat location is in seats list then update from "Open" to "Full"

            Show s = new Show();
            s.UpdateShow(seats, movie, timeSlot);

            Order o = new Order();
            int quantity = seats.Count;
            double subtotal = o.Calculate(quantity);    //subtotal for order

            frmReceipt receipt = new frmReceipt(subtotal);
            receipt.Show();
        }

        private void cbxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movie = cbxMovies.SelectedItem.ToString();
            DataTable movieDisplay = MovieManageSystem.GetMovie(movie);
            if (movieDisplay.Rows.Count > 0)
            {
                
                DataRow row = movieDisplay.Rows[0];

                lblDspTitle.Text = row["Title"].ToString();
                lblDspDirector.Text = row["Director"].ToString();
                lblDspRating.Text = row["Rating"].ToString();
                lblDspGenre.Text = row["Genre"].ToString();
                lblDspDescription.Text = row["Description"].ToString();
                pbxImg.SizeMode = PictureBoxSizeMode.Zoom;
                pbxImg.Load(row["Img"].ToString());
                try
                {
                    pbxImg.Load(row["Img"].ToString());
                }
                catch (Exception BadURL)
                {
                    MessageBox.Show("Bad Url");

                }
                ///////////////////////////// change cbx day ////////////
                ///
                //cbxShowDay.DataSource = ShowManageSystem.GetShowDayDB(row["Title"].ToString());
                cbxShowDay.DataSource = ShowManageSystem.GetShowDayDB(cbxMovies.SelectedItem.ToString());
               //cbxShowDay.DataSource = ShowManageSystem.GetShowDayArray(ShowManageSystem.GetShowDayDB());

                //cbxTimeSlots.DataSource = ShowManageSystem.GetShowTimeArray(ShowManageSystem.LoadShowsDB());
            }
            else
            {
              
                MessageBox.Show("Movie not found!");
            }

        }

        public void button1_Click(object sender, EventArgs e)  //btnFind
        {
            OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Shows.accdb");
            string movie = cbxMovies.SelectedItem.ToString();
            string timeSlot = cbxTimeSlots.SelectedItem.ToString();
            //string showDay = cbxShowDay.SelectedItem.ToString();

            //a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,d1,d2,d3,d4,d5,d6,d7,d8,d9,d10

            string strSQL = "SELECT a1 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a1ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a1ShowTable.Rows)   //update for all seats now.
            {
                string a1 = row["a1"].ToString();

                if (a1.Equals("full"))
                {
                    cba1.Hide();
                }
                else
                {
                    cba1.Show();
                }
            }

            strSQL = "SELECT a2 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a2ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a2ShowTable.Rows)   //update for all seats now.
            {
                string a2 = row["a2"].ToString();

                if (a2.Equals("full"))
                {
                    cba2.Hide();
                }
                else
                {
                    cba2.Show();
                }
            }

            strSQL = "SELECT a3 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a3ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a3ShowTable.Rows)   //update for all seats now.
            {
                string a3 = row["a3"].ToString();

                if (a3.Equals("full"))
                {
                    cba3.Hide();
                }
                else
                {
                    cba3.Show();
                }
            }

            strSQL = "SELECT a4 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a4ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a4ShowTable.Rows)
            {
                string a4 = row["a4"].ToString();

                if (a4.Equals("full"))
                {
                    cba4.Hide();
                }
                else
                {
                    cba4.Show();
                }
            }

            strSQL = "SELECT a5 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a5ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a5ShowTable.Rows)
            {
                string a5 = row["a5"].ToString();

                if (a5.Equals("full"))
                {
                    cba5.Hide();
                }
                else
                {
                    cba5.Show();
                }
            }

            strSQL = "SELECT a6 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a6ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a6ShowTable.Rows)
            {
                string a6 = row["a6"].ToString();

                if (a6.Equals("full"))
                {
                    cba6.Hide();
                }
                else
                {
                    cba6.Show();
                }
            }

            strSQL = "SELECT a7 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a7ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a7ShowTable.Rows)
            {
                string a7 = row["a7"].ToString();

                if (a7.Equals("full"))
                {
                    cba7.Hide();
                }
                else
                {
                    cba7.Show();
                }
            }

            strSQL = "SELECT a8 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a8ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a8ShowTable.Rows)
            {
                string a8 = row["a8"].ToString();

                if (a8.Equals("full"))
                {
                    cba8.Hide();
                }
                else
                {
                    cba8.Show();
                }
            }

            strSQL = "SELECT a9 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a9ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a9ShowTable.Rows)
            {
                string a9 = row["a9"].ToString();

                if (a9.Equals("full"))
                {
                    cba9.Hide();
                }
                else
                {
                    cba9.Show();
                }
            }

            strSQL = "SELECT a10 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable a10ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in a10ShowTable.Rows)
            {
                string a10 = row["a10"].ToString();

                if (a10.Equals("full"))
                {
                    cba10.Hide();
                }
                else
                {
                    cba10.Show();
                }
            }

            strSQL = "SELECT b1 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b1ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b1ShowTable.Rows)
            {
                string b1 = row["b1"].ToString();

                if (b1.Equals("full"))
                {
                    cbb1.Hide();
                }
                else
                {
                    cbb1.Show();
                }
            }

            strSQL = "SELECT b2 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b2ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b2ShowTable.Rows)
            {
                string b2 = row["b2"].ToString();

                if (b2.Equals("full"))
                {
                    cbb2.Hide();
                }
                else
                {
                    cbb2.Show();
                }
            }

            strSQL = "SELECT b3 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b3ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b3ShowTable.Rows)
            {
                string b3 = row["b3"].ToString();

                if (b3.Equals("full"))
                {
                    cbb3.Hide();
                }
                else
                {
                    cbb3.Show();
                }
            }

            strSQL = "SELECT b4 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b4ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b4ShowTable.Rows)
            {
                string b4 = row["b4"].ToString();

                if (b4.Equals("full"))
                {
                    cbb4.Hide();
                }
                else
                {
                    cbb4.Show();
                }
            }

            strSQL = "SELECT b5 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b5ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b5ShowTable.Rows)
            {
                string b5 = row["b5"].ToString();

                if (b5.Equals("full"))
                {
                    cbb5.Hide();
                }
                else
                {
                    cbb5.Show();
                }
            }

            strSQL = "SELECT b6 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b6ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b6ShowTable.Rows)
            {
                string b6 = row["b6"].ToString();

                if (b6.Equals("full"))
                {
                    cbb6.Hide();
                }
                else
                {
                    cbb6.Show();
                }
            }

            strSQL = "SELECT b7 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b7ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b7ShowTable.Rows)
            {
                string b7 = row["b7"].ToString();

                if (b7.Equals("full"))
                {
                    cbb7.Hide();
                }
                else
                {
                    cbb7.Show();
                }
            }

            strSQL = "SELECT b8 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b8ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b8ShowTable.Rows)
            {
                string b8 = row["b8"].ToString();

                if (b8.Equals("full"))
                {
                    cbb8.Hide();
                }
                else
                {
                    cbb8.Show();
                }
            }

            strSQL = "SELECT b9 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b9ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b9ShowTable.Rows)
            {
                string b9 = row["b9"].ToString();

                if (b9.Equals("full"))
                {
                    cbb9.Hide();
                }
                else
                {
                    cbb9.Show();
                }
            }

            strSQL = "SELECT b10 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable b10ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in b10ShowTable.Rows)
            {
                string b10 = row["b10"].ToString();

                if (b10.Equals("full"))
                {
                    cbb10.Hide();
                }
                else
                {
                    cbb10.Show();
                }
            }

            strSQL = "SELECT c1 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c1ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c1ShowTable.Rows)
            {
                string c1 = row["c1"].ToString();

                if (c1.Equals("full"))
                {
                    cbc1.Hide();
                }
                else
                {
                    cbc1.Show();
                }
            }

            strSQL = "SELECT c2 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c2ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c2ShowTable.Rows)
            {
                string c2 = row["c2"].ToString();

                if (c2.Equals("full"))
                {
                    cbc2.Hide();
                }
                else
                {
                    cbc2.Show();
                }
            }

            strSQL = "SELECT c3 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c3ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c3ShowTable.Rows)
            {
                string c3 = row["c3"].ToString();

                if (c3.Equals("full"))
                {
                    cbc3.Hide();
                }
                else
                {
                    cbc3.Show();
                }
            }

            strSQL = "SELECT c4 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c4ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c4ShowTable.Rows)
            {
                string c4 = row["c4"].ToString();

                if (c4.Equals("full"))
                {
                    cbc4.Hide();
                }
                else
                {
                    cbc4.Show();
                }
            }

            strSQL = "SELECT c5 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c5ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c5ShowTable.Rows)
            {
                string c5 = row["c5"].ToString();

                if (c5.Equals("full"))
                {
                    cbc5.Hide();
                }
                else
                {
                    cbc5.Show();
                }
            }

            strSQL = "SELECT c6 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c6ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c6ShowTable.Rows)
            {
                string c6 = row["c6"].ToString();

                if (c6.Equals("full"))
                {
                    cbc6.Hide();
                }
                else
                {
                    cbc6.Show();
                }
            }

            strSQL = "SELECT c7 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c7ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c7ShowTable.Rows)
            {
                string c7 = row["c7"].ToString();

                if (c7.Equals("full"))
                {
                    cbc7.Hide();
                }
                else
                {
                    cbc7.Show();
                }
            }

            strSQL = "SELECT c8 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c8ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c8ShowTable.Rows)
            {
                string c8 = row["c8"].ToString();

                if (c8.Equals("full"))
                {
                    cbc8.Hide();
                }
                else
                {
                    cbc8.Show();
                }
            }

            strSQL = "SELECT c9 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c9ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c9ShowTable.Rows)
            {
                string c9 = row["c9"].ToString();

                if (c9.Equals("full"))
                {
                    cbc9.Hide();
                }
                else
                {
                    cbc9.Show();
                }
            }

            strSQL = "SELECT c10 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable c10ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in c10ShowTable.Rows)
            {
                string c10 = row["c10"].ToString();

                if (c10.Equals("full"))
                {
                    cbc10.Hide();
                }
                else
                {
                    cbc10.Show();
                }
            }

            strSQL = "SELECT d1 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d1ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d1ShowTable.Rows)
            {
                string d1 = row["d1"].ToString();

                if (d1.Equals("full"))
                {
                    cbd1.Hide();
                }
                else
                {
                    cbd1.Show();
                }
            }

            strSQL = "SELECT d2 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d2ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d2ShowTable.Rows)
            {
                string d2 = row["d2"].ToString();

                if (d2.Equals("full"))
                {
                    cbd2.Hide();
                }
                else
                {
                    cbd2.Show();
                }
            }

            strSQL = "SELECT d3 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d3ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d3ShowTable.Rows)
            {
                string d3 = row["d3"].ToString();

                if (d3.Equals("full"))
                {
                    cbd3.Hide();
                }
                else
                {
                    cbd3.Show();
                }
            }

            strSQL = "SELECT d4 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d4ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d4ShowTable.Rows)
            {
                string d4 = row["d4"].ToString();

                if (d4.Equals("full"))
                {
                    cbd4.Hide();
                }
                else
                {
                    cbd4.Show();
                }
            }

            strSQL = "SELECT d5 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d5ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d5ShowTable.Rows)
            {
                string d5 = row["d5"].ToString();

                if (d5.Equals("full"))
                {
                    cbd5.Hide();
                }
                else
                {
                    cbd5.Show();
                }
            }

            strSQL = "SELECT d6 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d6ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d6ShowTable.Rows)
            {
                string d6 = row["d6"].ToString();

                if (d6.Equals("full"))
                {
                    cbd6.Hide();
                }
                else
                {
                    cbd6.Show();
                }
            }

            strSQL = "SELECT d7 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d7ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d7ShowTable.Rows)
            {
                string d7 = row["d7"].ToString();

                if (d7.Equals("full"))
                {
                    cbd7.Hide();
                }
                else
                {
                    cbd7.Show();
                }
            }

            strSQL = "SELECT d8 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d8ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d8ShowTable.Rows)
            {
                string d8 = row["d8"].ToString();

                if (d8.Equals("full"))
                {
                    cbd8.Hide();
                }
                else
                {
                    cbd8.Show();
                }
            }

            strSQL = "SELECT d9 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d9ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d9ShowTable.Rows)
            {
                string d9 = row["d9"].ToString();

                if (d9.Equals("full"))
                {
                    cbd9.Hide();
                }
                else
                {
                    cbd9.Show();
                }
            }

            strSQL = "SELECT d10 FROM ShowsTable WHERE Movie = '" + movie + "' AND ShowTime = '" + timeSlot + "'";

            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            showDataSet = new DataSet("ShowsTable");
            myDataAdapter.Fill(showDataSet, "ShowsTable");

            DataTable d10ShowTable = showDataSet.Tables["ShowsTable"];

            foreach (DataRow row in d10ShowTable.Rows)
            {
                string d10 = row["d10"].ToString();

                if (d10.Equals("full"))
                {
                    cbd10.Hide();
                }
                else
                {
                    cbd10.Show();
                }
            }
        }

        private void cbxShowDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTimeSlots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
