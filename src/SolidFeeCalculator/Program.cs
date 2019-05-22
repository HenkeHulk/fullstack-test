using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidFeeCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fee = 0;
            int usertype = 1, itemtype = 1, itemprice = 100;
            DateTime itemenddate = DateTime.Today;

            try
            {
                if(args.Length > 0)
                    usertype = int.Parse(args[0]);
                if(args.Length > 1)
                    itemtype = int.Parse(args[1]);
                if(args.Length > 2)
                    itemprice = int.Parse(args[2]);
                if(args.Length > 3)
                    itemenddate = DateTime.Parse(args[3]);
                fee = CalculateFee(usertype, itemtype, itemprice, itemenddate);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }

            Console.WriteLine(fee.ToString());
            Console.Read();
        }

        /// <summary>
        ///   This function handles all calculation you ever need!
        /// </summary>
        /// <param name="usertype"> 0= Normal, 1 = Company</param>
        /// <param name="itemtype"> 0= Auction, 1 = BuyItNow</param>
        /// <param name="itemprice"></param>
        /// <param name="itemenddate">Time Item ends </param>
        /// <returns></returns>
        public static int CalculateFee(int usertype, int itemtype, int itemprice,  DateTime itemenddate)
        {
            try
            {
                decimal percentage;

                switch (usertype)
                {
                    case 0: //Normal
                         percentage = 0.07m;
                        #region Normal user
                        int itemfeeN = Decimal.ToInt32(itemprice * percentage);
                        if (itemtype == 0) //Auction
                        {
                            var enddateDiscount = 0;
                            if (itemenddate == DateTime.Today) enddateDiscount = 10;

                            return itemfeeN + 25 - enddateDiscount;
                        }
                        else if (itemtype == 1) //BuyItNow
                        {
                            var enddateDiscount = 0;
                            if (itemenddate == DateTime.Today) enddateDiscount = 10;

                            return itemfeeN + 35 - enddateDiscount;
                        }
                        break; 
	                    #endregion
                    case 1: //Company
                        percentage = 0.04m;
                        #region Company
                        int itemfee = Decimal.ToInt32(itemprice * percentage);
                        if (itemtype == 0) //Auction
                        {
                            if (itemenddate == DateTime.Today)
                                return itemfee + 25 - 15;// Enddate discount and company discount

                            return itemfee + 25 - 5;// Only company discount
                        }
                        else if (itemtype == 1) //BuyItNow
                        {
                            if (itemenddate == DateTime.Today)
                                return itemfee + 35 - 15;// Enddate discount and company discount

                            return itemfee + 35 - 5;// Only company discount
                        }
                        break; 
                        #endregion
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            return 0;
        }
    }
}
