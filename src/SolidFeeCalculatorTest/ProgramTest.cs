using NUnit.Framework;
using SolidFeeCalculator;
using System;

namespace SolidFeeCalculatorTest
{
    
    
    [TestFixture]
    public class ProgramTest
    {
        #region variables

        int expectedItemPrice = 100; //Itemprice
        int auctionToday = 22; //Fee for an auction that starts and ends today for a normal user
        int auctionTomorrow = 32; //Fee for an auction that starts today and ends tomorrow for a normal user
        int buynowToday = 32; //Fee for a buy now item that starts and ends today for a normal user
        int buynowTomorrow = 42; //Fee for a buy now item that starts today and ends tomorrow for a normal user
        int compAuctionToday = 14; //Fee for an auction that starts and ends today for a company user
        int compBuyNowToday = 24; //Fee for a buy now item that starts and ends today for a company user
        int compAuctionTomorrow = 24; //Fee for an auction that starts today and ends tomorrow for a company user
        int compBuyNowTomorrow = 34; //Fee for a buy now item that starts today and ends tomorrow for a company user

        #endregion

        #region Normal User
        //Checking that the fee of an auction item with an itemprice of 100 and enddate is equal to startdate for a normal user
        [Test]
        public void CalculateNormalAuctionFeeEndDateTodayTest()
        {
            int userType = 0; // UserType 0 = Normal user
            int itemType = 0; // ItemType 0 = Auction
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today; // Enddate today
            int expected = auctionToday; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of a buy now item with an itemprice of 100 and enddate is equal to startdate for a normal user
        [Test]
        public void CalculateNormalBuyNowEndDateTodayFeeTest()
        {
            int userType = 0; // UserType 0 = Normal user
            int itemType = 1; // ItemType 1 = Buy Now
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today; // Enddate today
            int expected = buynowToday; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of an auction item with an itemprice of 100 and enddate is not equal to startdate for a normal user
        [Test]
        public void CalculateNormalAuctionFeeEndDateTomorrowTest()
        {
            int userType = 0; // UserType 0 = Normal user
            int itemType = 0; // ItemType 0 = Auction
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today.AddDays(1); // Enddate tomorrow
            int expected = auctionTomorrow; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of a buy now item with an itemprice of 100 and enddate is not equal to startdate for a normal user
        [Test]
        public void CalculateNormalBuyNowEndDateTomorrowFeeTest()
        {
            int userType = 0; // UserType 0 = Normal user
            int itemType = 1; // ItemType 1 = Buy Now
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today.AddDays(1); // Enddate tomorrow
            int expected = buynowTomorrow; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Company User

        //Checking that the fee of an auction item with an itemprice of 100 and enddate is equal to startdate for a company user
        [Test]
        public void CalculateCompUserAuctionFeeEndDateTodayTest()
        {
            int userType = 1; // UserType 1 = Company user
            int itemType = 0; // ItemType 0 = Auction
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today; // Enddate Today
            int expected = compAuctionToday; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of a buy now item with an itemprice of 100 and enddate is equal to startdate for a company user
        [Test]
        public void CalculatewCompUserBuyNowEndDateTodayFeeTest()
        {
            int userType = 1; // UserType 1 = Company user
            int itemType = 1; // ItemType 1 = Buy Now
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today; // Enddate Today
            int expected = compBuyNowToday; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of an auction item with an itemprice of 100 and enddate is not equal to startdate for a company user
        [Test]
        public void CalculateCompUserAuctionFeeEndDateTomorrowTest()
        {
            int userType = 1; // UserType 1 = Company user
            int itemType = 0; // ItemType 0 = Auction
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today.AddDays(1); // Enddate Tomorrow
            int expected = compAuctionTomorrow; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }

        //Checking that the fee of a buy now item with an itemprice of 100 and enddate is not equal to startdate for a company user
        [Test]
        public void CalculateCompUserBuyNowEndDateTomorrowFeeTest()
        {
            int userType = 1; // UserType 1 = Company user
            int itemType = 1; // ItemType 1 = Buy Now
            int itemPrice = expectedItemPrice; // Itemprice
            DateTime itemEndDate = DateTime.Today.AddDays(1); // Enddate Tomorrow
            int expected = compBuyNowTomorrow; // Expected sum of the fee
            int actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
