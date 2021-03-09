using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
/*
 * Domæne model
interface polymorfi via interface
interface til at kunne køde og sælge til

køber og sælger som interfaces

privat og company som klasser
 */
    abstract class User : IBuyer, ISeller
    {
        protected User()
        {
            this.balance = 0.00M;
        }
        private decimal balance;

        public int Zipcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Gives the seller a nodifikatsion that a bid has been made on a veihcle for sale.
        /// </summary>
        /// <returns>the nodifikation as a string.</returns>
        public string BidNodification()
        {
            throw new NotImplementedException();
        }
    }

    class CorporateUser : User
    {
        int CVRNumber { get; set; }
        int Credit { get; set; }
    }

    class PrivateUser : User
    {
        int CPRNumber { get; set; }
    }

}
