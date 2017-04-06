using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterKataApp;

namespace BabySitterWageTester
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void basicFailedTest()
        //{
        //    double pay = Program.WageCalc(9);

        //    Assert.AreEqual(0, pay);
        //}

        [TestMethod]
        public void WageTest_BeforeBedtime()
        {
            // 5 hours worked

            int pay = Program.WageCalc(5, 0, 5);

            Assert.AreEqual(60, pay);
        }

        [TestMethod]
        public void Wage_AFterBedtime()
        {
            //5 hours worked
            //startTime begins at 5pm with value of '0'. it goes up to 4am with a value of 11.
            // hours from start time to bedTime. example startTime is 7pm, and bedtime at 9pm. Value would be 2. 
            // pay equals $42

            int pay = Program.WageCalc(5, 2, 1);

            Assert.AreEqual(44, pay);
        }

        [TestMethod]
        public void AfterBedtime_BeforeMidnite()
        {
            // 3 hours of work
            // started at 7pm, and ends at 10pm.
            // bedtime is 8pm, which is 1 hour after start time.
            // Wage should equal 28

            double pay = Program.WageCalc(3, 2, 1 );

            Assert.AreEqual(28, pay);
        }

        [TestMethod]
        public void WageTest_AfterMidnite()
        {
            // totalTime is 10 hours
            // start time is 5pm
            // bedtime is 11pm, which is 6 hours from start time
            //wage should equal $128
            //
            int pay = Program.WageCalc(10, 0, 6);

            Assert.AreEqual(128, pay);
        }


    }
}
