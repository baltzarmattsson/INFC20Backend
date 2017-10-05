using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INFC20Backend.Models
{
    public class Bid
    {
        public String Email { get; set; }
        public int ListingId { get; set; }
        public double Amount { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}