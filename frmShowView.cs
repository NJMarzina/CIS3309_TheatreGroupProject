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
            cbxFilterTime.DataSource = CIS3309_TheatreGroupProject.Show.GetTimeSlotArray();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvShows.DataSource = ShowManageSystem.FilterShowMovieDB(cbxMovieTitle.SelectedItem.ToString());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddShow addAShow = new frmAddShow();
            addAShow.ShowDialog();

        }

        private void frmShowView_Load(object sender, EventArgs e)
        {

        }

        private void cbxMovieTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbxFilterTime.SelectedItem.ToString());
            dgvShows.DataSource = ShowManageSystem.FilterShowTimeDB(cbxFilterTime.SelectedItem.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
     
                if (dgvShows.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Ensure you select a row");
                }
                else
                {
                    string show = (string)dgvShows.SelectedRows[0].Cells["Show"].Value;
                    string title = (string)dgvShows.SelectedRows[0].Cells["Title"].Value;
                MessageBox.Show("Selected for delete: " + title);
                    ShowManageSystem.DeleteShowDB(show);
                    dgvShows.DataSource = ShowManageSystem.LoadShowsDB();
                }

            
        }
    }
}
