using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            foreach (var kvp in theaterRoom.seatChart)
            {
                seatStatus.AppendLine($"Seat {kvp.Key}: {kvp.Value}");
            }

            // Display the seat status in a MessageBox
            MessageBox.Show(seatStatus.ToString(), "Seat Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string movieTitle = cbxMovieTitle.SelectedItem.ToString();
            Show.TimeSlot selectedTimeSlot = (Show.TimeSlot)cbxTimeSlot.SelectedItem;
            Show show = new Show(theaterRoom, movieTitle, selectedTimeSlot);
            ShowManageSystem.InsertShowDB(show);





        }
    }
}
