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
    public class ShowTests
    {
        [TestMethod()]
        public void ShowTest()
        {
            //  CREATE SHOW 
            TheaterRoom theaterRoom = new TheaterRoom("Room1");
            DateTime showDay = DateTime.Now;
            Show.TimeSlot timeSlot = Show.TimeSlot.SLOT_0800_1130;

            Show show = new Show(theaterRoom, "Movie1", showDay, timeSlot);

            // TEST OBJ 
            Assert.AreNotEqual(null, show);

            // TEST OBJ FIELDS
            Assert.AreEqual(theaterRoom, show.TheaterRoom);
            Assert.AreEqual("Movie1", show.MovieTitle);
            Assert.AreEqual(showDay, show.ShowDay);
            Assert.AreEqual(timeSlot, show.ShowTime);

            // TEST CHANGE TO FIELD
            show.MovieTitle = "New";
            Assert.AreNotEqual("Movie1", show.MovieTitle);
            Assert.AreEqual("New", show.MovieTitle);
        }

        [TestMethod()]
        public void GetTimeSlotArrayTest()
        {
            // CREATE ARRAY
            Array array = Show.GetTimeSlotArray();

            // ENSURE IT IS NOT NULL

            Assert.AreNotEqual(null, array);

            // CHECK FOR ARRAY LENGTH
            Assert.AreEqual(4, array.Length);
            Assert.AreNotEqual(3, array.Length);

            // CHECK ARRAY VALUES

            Assert.AreEqual(Show.TimeSlot.SLOT_0800_1130, array.GetValue(0));
            Assert.AreEqual(Show.TimeSlot.SLOT_1130_1500, array.GetValue(1));
            Assert.AreEqual(Show.TimeSlot.SLOT_1500_1830, array.GetValue(2));
            Assert.AreEqual(Show.TimeSlot.SLOT_1830_2200, array.GetValue(3));
        }
        //OTHER METHODS HEAVILY RELY ON DB, WAS TOLD NOT TO TEST THEM BY PROF
    }
}