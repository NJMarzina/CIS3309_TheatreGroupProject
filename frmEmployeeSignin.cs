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
    public partial class frmEmployeeSignin : Form
    {
        String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataReader myReader;
        OleDbDataAdapter myAdapter;
        DataTable employeeTable;

        public frmEmployeeSignin()
        {
            InitializeComponent();
        }

        public bool btnLogin_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool tf = emp.checkLogin(username, password);

            if(tf)
            {
                MessageBox.Show("You have been successfully signed in.");
            }
            else
            {
                MessageBox.Show("Please enter correct credentials.");
            }

            return tf;
        }

        public void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmp = new frmNewEmployee();

            newEmp.Show();
        }
    }
}
