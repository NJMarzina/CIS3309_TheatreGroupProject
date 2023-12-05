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
        }

        public void frmBuyTickets_Load(object sender, EventArgs e)
        {
            //filter by movie
            //filter by time slot
        }
    }
}
