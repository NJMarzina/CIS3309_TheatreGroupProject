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
            string movie = cbxMovies.SelectedItem.ToString();
            string timeSlot = cbxTimeSlots.SelectedItem.ToString();

            Enum.Parse(typeof(TimeSlot), timeSlot);

            //movie selected
            //time selected

            //pull info from movie and time
            //iterate through database, if a1==full then cba1==checked...
            //if cba1 becomes checked upon submitting button, then a1=full
        }
    }
}
