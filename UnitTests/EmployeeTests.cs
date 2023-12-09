using CIS3309_TheatreGroupProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CIS3309_TheatreGroupProject.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void EmployeeTest()
        {
            string name = "test name";
            string username = "test username";
            string password = "test password";

            Employee e1 = new Employee(name, username, password);
            Employee e2 = new Employee(name, username, password);
            // TEST OVERALL OBJECT
            Assert.AreNotEqual(e1, null);
            Assert.AreEqual(e1, e2);

            //   TEST FIELDS
            Assert.AreEqual(e1.Name, name);
            Assert.AreEqual(e1.Username, username);
            Assert.AreEqual(e1.Password, password);

            // TEST CHANGES TO FIELD
            e1.Name = "Joseph Jay";
            Assert.AreNotEqual(e1.Name, name);
            Assert.AreEqual(e1.Name, "Joseph Jay");
        }
    }
}
