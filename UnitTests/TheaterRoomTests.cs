using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS3309_TheatreGroupProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject.Tests
{
    [TestClass()]
    public class TheaterRoomTests
    {
        [TestMethod()]
        public void TheaterRoomTest()
        {
            /// CREATE ROOM
            TheaterRoom theaterRoom = new TheaterRoom("room");
            // ESURE IT IS NOT NULL
            Assert.AreNotEqual(null, theaterRoom);



            // TETST THE OBJ FIELDS
            Assert.AreEqual("room", theaterRoom.room);

            // 
            Assert.AreNotEqual(39, theaterRoom.seatChart.Count);
            Assert.AreEqual(40, theaterRoom.seatChart.Count);
            Assert.AreNotEqual(41, theaterRoom.seatChart.Count);

            // CHECKS EACH SEAT STATUS // ALL SHOULD BE OPEN AFTER CREATING THE NEW SHOW
            foreach (var seatStatus in theaterRoom.seatChart.Values)
            {
                Assert.AreEqual(TheaterRoom.SeatStatus.open, seatStatus);
            }
        }


    }
}