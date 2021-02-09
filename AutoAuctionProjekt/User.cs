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
    abstract class User : BuyerModel, SellerModel
    {
        private decimal balance;

        public int Postnummer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
