using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CIS3309_TheatreGroupProject.TheaterRoom;

namespace CIS3309_TheatreGroupProject
{
    public partial class frmAddShow : Form
    {
        public frmAddShow()
        {
            InitializeComponent();

            cbxTimeSlot.DataSource = CIS3309_TheatreGroupProject.Show.GetTimeSlotArray();
            cbxMovieTitle.DataSource = MovieManageSystem.GetMovieTitles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheaterRoom theaterRoom = new TheaterRoom(tbxTheaterRoom.Text);
            StringBuilder seatStatus = new StringBuilder();


            string movieTitle = cbxMovieTitle.SelectedItem.ToString();
            Show.TimeSlot selectedTimeSlot = (Show.TimeSlot)cbxTimeSlot.SelectedItem;
            DateTime showDay;


            ///// GETTING SHOWDAY TO BE IN FORMAT MM/DD/YY   /////////////////////////
            if (DateTime.TryParseExact(tbxShowDay.Text, "MM/dd/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out showDay))
            {
                Show show = new Show(theaterRoom, movieTitle, showDay, selectedTimeSlot);
                ShowManageSystem.InsertShowDB(show);
                MessageBox.Show("Your show has been added");

            }
            else
            {
               
                MessageBox.Show("Invalid date format. Please enter the date in MM/dd/yy format.");
                
            }
        

        }
    }
}
