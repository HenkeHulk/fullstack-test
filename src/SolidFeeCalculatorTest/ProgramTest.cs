using NUnit.Framework;
using SolidFeeCalculator;
using System;

namespace SolidFeeCalculatorTest
{
    
    
    [TestFixture]
    public class ProgramTest
    {
        #region Normal User
        [Test]
        public void CalculateNormalAuctionFeeEndDateTodayTest()
        {
            int userType = 0; // TODO: Initialize to an appropriate value
            int itemType = 0; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today; // TODO: Initialize to an appropriate value
            int expected = 22; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalculateNormalBuyNowEndDateTodayFeeTest()
        {
            int userType = 0; // TODO: Initialize to an appropriate value
            int itemType = 1; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today; // TODO: Initialize to an appropriate value
            int expected = 32; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateNormalAuctionFeeEndDateTomorrowTest()
        {
            int userType = 0; // TODO: Initialize to an appropriate value
            int itemType = 0; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today.AddDays(1); // TODO: Initialize to an appropriate value
            int expected = 32; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalculateNormalBuyNowEndDateTomorrowFeeTest()
        {
            int userType = 0; // TODO: Initialize to an appropriate value
            int itemType = 1; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today.AddDays(1); // TODO: Initialize to an appropriate value
            int expected = 42; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Company User
        [Test]
        public void CalculateCompUserAuctionFeeEndDateTodayTest()
        {
            int userType = 1; // TODO: Initialize to an appropriate value
            int itemType = 0; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today; // TODO: Initialize to an appropriate value
            int expected = 14; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalculatewCompUserBuyNowEndDateTodayFeeTest()
        {
            int userType = 1; // TODO: Initialize to an appropriate value
            int itemType = 1; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today; // TODO: Initialize to an appropriate value
            int expected = 24; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateCompUserAuctionFeeEndDateTomorrowTest()
        {
            int userType = 1; // TODO: Initialize to an appropriate value
            int itemType = 0; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today.AddDays(1); // TODO: Initialize to an appropriate value
            int expected = 24; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalculateCompUserBuyNowEndDateTomorrowFeeTest()
        {
            int userType = 1; // TODO: Initialize to an appropriate value
            int itemType = 1; // TODO: Initialize to an appropriate value
            int itemPrice = 100; // TODO: Initialize to an appropriate value
            DateTime itemEndDate = DateTime.Today.AddDays(1); // TODO: Initialize to an appropriate value
            int expected = 34; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
