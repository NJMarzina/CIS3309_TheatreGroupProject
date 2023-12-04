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
    public partial class frmShowView : Form
    {
        public frmShowView()
        {
            InitializeComponent();
            dgvShows.DataSource = ShowManageSystem.LoadShowsDB();
            cbxMovieTitle.DataSource = MovieManageSystem.GetMovieTitles(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
