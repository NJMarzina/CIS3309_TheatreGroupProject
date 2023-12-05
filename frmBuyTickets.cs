using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_TheatreGroupProject
{
    public partial class frmBuyTickets : Form
    {
        public frmBuyTickets()
        {
            InitializeComponent();
            cbxMovies.DataSource = MovieManageSystem.GetMovieTitles();
            cbxTimeSlots.DataSource = CIS3309_TheatreGroupProject.Show.GetTimeSlotArray();
        }

        public void frmBuyTickets_Load(object sender, EventArgs e)
        {
            string movie = cbxMovies.SelectedItem.ToString();
            //filter by movie
            //filter by time slot

            //8:00am - 11:30am
            //11:30am - 3:00pm
            //3:00pm - 6:30pm
            //6:30pm - 10:00pm
        }
    }
}
