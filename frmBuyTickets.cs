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
