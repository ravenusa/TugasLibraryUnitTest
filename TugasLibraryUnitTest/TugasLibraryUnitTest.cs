using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibrary
{
    [TestFixture]
    public class TugasLibraryTest
    {
        private Day day;
        private User user;

        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
            Assert.AreEqual("Selasa", day.NameOfDay(2));
            Assert.AreEqual("Rabu", day.NameOfDay(3));
            Assert.AreEqual("Kamis", day.NameOfDay(4));
            Assert.AreEqual("Jum'at", day.NameOfDay(5));
            Assert.AreEqual("Sabtu", day.NameOfDay(6));
            Assert.AreEqual("Minggu", day.NameOfDay(7));
            Assert.AreEqual("", day.NameOfDay(8));

        }
        [Test]
        public void TestUserValid()
        {        
           Assert.IsTrue(user.IsValidUser("admin", "admin"));
           Assert.IsFalse(user.IsValidUser("",""));


        }

    }
}