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
    public partial class frmReceipt : Form
    {
        public frmReceipt(double subtotal, string movie, int quantity, string timeSlot)
        {
            InitializeComponent();
            lblAmount.Text = "Ticket Quantity...................................." + quantity;
            lblMovie.Text = "Movie..................................................." + movie;
            lblTime.Text =  "Time...................................................." + timeSlot;
            lblSubtotal.Text = "Subtotal.............................................." + subtotal.ToString();
        }

        public void frmReceipt_Load(object sender, EventArgs e)
        {
            
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
