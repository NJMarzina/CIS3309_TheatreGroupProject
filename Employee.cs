using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    class Employee
    {
        string name;
        string username;
        string password;

        public Employee()
        {

        }

        public Employee(string name, string username, string password)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        public bool checkLogin(string u, string p)
        {
            //will contain logic of if employee exists within the database and returns true or false

            String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

            OleDbConnection myConnection;
            OleDbCommand myCommand;
            OleDbDataReader myReader;
            OleDbDataAdapter myAdapter;
            DataTable employeeTable;

            return true;
        }

        public void addEmployee(string fn, string u, string p)
        {
            //will contain logic of if employee exists within the database and returns true or false

            String connectionStringEmployees = "provider = Microsoft.ACE.OLEDB.12.0; Data Source = Employees.accdb;";

            //OleDbConnection myConnection;
            OleDbCommand myCommand;
            OleDbDataReader myReader;
            OleDbDataAdapter myAdapter;
            DataTable employeeTable;

            Employee emp = new Employee();
            OleDbConnection myConnection = new OleDbConnection(connectionStringEmployees);

            emp.Name = fn;
            emp.Username = u;
            emp.Password = p;

            string strSQL = "INSERT INTO Employees (FullName, Username, [Password])" +
            "VALUES ('" + emp.Name + "','" + emp.Username + "','" + emp.Password + "')";

            DataSet empDataSet = new DataSet();

            myAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myAdapter.Fill(empDataSet, "Employees");
            employeeTable = empDataSet.Tables["Employees"];
        }
    }
}
