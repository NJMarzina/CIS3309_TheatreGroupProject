using CIS3309_TheatreGroupProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CIS3309_TheatreGroupProject.Tests
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        public void TicketTest()
        {
            double price = 10.0;
            Ticket t = new Ticket(price);

            Assert.AreEqual(t.Price, price);
            Assert.AreNotEqual(price, 0);
            Assert.AreNotEqual(t.Price, 0);

            price = 5.0;

            Assert.AreNotEqual(t.Price, price);
        }
    }
}
