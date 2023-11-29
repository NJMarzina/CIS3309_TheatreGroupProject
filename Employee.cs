using System;
using System.Collections.Generic;
using System.Linq;
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

            return true;
        }
    }
}
