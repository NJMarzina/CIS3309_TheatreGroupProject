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
    public partial class frmMovieView : Form
    {
        public frmMovieView()
        {
            InitializeComponent();
            dgvMovie.DataSource = MovieManageSystem.LoadMoiveDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = (string)dgvMovie.SelectedRows[0].Cells["Title"].Value;
            MessageBox.Show("Selected for delete: " + title);
            MovieManageSystem.DeleteMovieDB(title);
            dgvMovie.DataSource = MovieManageSystem.LoadMoiveDB();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddMovie form = new frmAddMovie();
            form.Show();
        }

        private void dgvMovie_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                string columnName = dgv.Columns[e.ColumnIndex].Name;
                string title = dgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();

                object newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Call the UpdateDB method to update the database
                MovieManageSystem.UpdateDB(title, columnName, newValue);
            }
        }
    }
}
