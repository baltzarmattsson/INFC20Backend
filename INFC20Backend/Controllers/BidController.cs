using INFC20Backend.DataAccessLayer;
using INFC20Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace INFC20Backend.Controllers
{
    public class BidController : ApiController
    {

        private BidDAL bidDal = new BidDAL();

        // temp
        [HttpGet]
        [Route("api/Bid/GetTempListings")]
        public async Task<HttpResponseMessage> GetTempListings() {

            var tempListings = new[] {
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 1", title = "Title 1" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 2", title = "Title 2" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 3", title = "Title 3" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 4", title = "Title 4" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 5", title = "Title 5" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 6", title = "Title 6" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 7", title = "Title 7" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 8", title = "Title 8" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 9", title = "Title 9" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 10", title = "Title 10" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 11", title = "Title 11" },
                new { start_time = 0, end_time = 0, number = -1, picture = "", description = "Description 12", title = "Title 12" },
            }.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, tempListings);
        }

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
