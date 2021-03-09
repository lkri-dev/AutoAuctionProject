using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    /// <summary>
    /// 
    /// </summary>
    class AuctionHouse
    {
        public AuctionHouse()
        {
            this.vehicles = new List<Vehicle>();
        }
        public List<Vehicle> vehicles;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seller"></param>
        /// <returns></returns>
        public int SetForSale(ISeller seller)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seller"></param>
        /// <param name="BidNodification"></param>
        /// <returns></returns>
        public int SetForSale(ISeller seller, Func<string> BidNodification)
        {
            BidNodification();
            Console.WriteLine(seller.Zipcode);
            throw new NotImplementedException();
        }
    }
}
