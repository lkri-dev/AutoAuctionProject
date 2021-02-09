using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    public interface SellerModel
    {
        int Postnummer { get; set; }

        string BidNodification();
    }
}
