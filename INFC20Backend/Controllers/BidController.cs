using INFC20Backend.DataAccessLayer;
using INFC20Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace INFC20Backend.Controllers
{
    public class BidController : ApiController
    {

        private BidDAL bidDal = new BidDAL(); 

        // GET: api/Bid
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bid/5
        [HttpGet]
        [Route("api/Bid/{email}/{listingId}/{amount}")]
        public Bid Get(string email, int listingId, double amount)
        {
            return this.bidDal.GetBid(email, listingId, amount);
            //return "value";
        }

        // POST: api/Bid
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bid/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bid/5
        public void Delete(int id)
        {
        }
    }
}
