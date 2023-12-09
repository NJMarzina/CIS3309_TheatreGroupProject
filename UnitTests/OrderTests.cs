using CIS3309_TheatreGroupProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CIS3309_TheatreGroupProject.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void OrderTest()
        {
            double total = 10.0;
            Order o = new Order(total);

            Assert.AreNotEqual(total, null);
            Assert.AreEqual(total, 10.0);

            Assert.AreEqual(o.Total, total);
        }

        [TestMethod()]
        public void CalculateTest()
        {
            int quantity = 2;
            double subtotal = 21.4;
            Order o = new Order();

            Assert.AreEqual(o.Calculate(quantity), subtotal);
            Assert.AreNotEqual(quantity, subtotal);
        }
    }
}
