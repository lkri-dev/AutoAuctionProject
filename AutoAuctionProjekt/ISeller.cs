using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAuctionProjekt
{
    public interface ISeller
    {
        int Zipcode { get; set; }

        string BidNodification();
    }
}
