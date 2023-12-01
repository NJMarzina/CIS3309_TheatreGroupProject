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
    public partial class frmAddMovie : Form
    {
        public frmAddMovie()
        {
            InitializeComponent();
            cbxGenre.DataSource = Enum.GetValues(typeof(Movie.Genre));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie(tbxMovie.Text, (Movie.Genre)cbxGenre.SelectedItem, tbxDirector.Text, tbxRating.Text, tbxDescription.Text, tbxImg.Text);
            MovieManageSystem.InsertMovieDB(newMovie);
            
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
