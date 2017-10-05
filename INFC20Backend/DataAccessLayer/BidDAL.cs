using INFC20Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INFC20Backend.DataAccessLayer
{
    public class BidDAL
    {

        public Bid GetBid(string email, int listingId, double amount)
        {
            // connect to connector
            // call stored procedure
            // get object
            // return object

            if (email == "1")
            {
                return new Bid() { Email = "temp1", Amount = 1.0, ListingId = 1337, TimeStamp = DateTime.Now };
            }
            else
            {
                return new Bid() { Email = "temp222222", Amount = 1514124.0, ListingId = 1124123433, TimeStamp = DateTime.Now };
            }
        }
    }
}