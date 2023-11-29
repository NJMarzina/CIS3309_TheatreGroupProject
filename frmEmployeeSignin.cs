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
    public partial class frmEmployeeSignin : Form
    {
        String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

        public frmEmployeeSignin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
