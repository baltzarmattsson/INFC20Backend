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

        [HttpGet]
        [Route("api/Bid/GetTempBids")]
        public async Task<HttpResponseMessage> GetTempBids()
        {
            var tempBids0 = new[]
              {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            var tempBids1 = new[]
               {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            var tempBids2 = new[]
    {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            return Request.CreateResponse(HttpStatusCode.OK, tempBids0.Concat(tempBids1).Concat(tempBids2) );
        }

        // temp
        [HttpGet]
        [Route("api/Bid/GetTempListings")]
        public async Task<HttpResponseMessage> GetTempListings()
        {

            var tempBids0 = new[]
            {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            var tempBids1 = new[]
               {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            var tempBids2 = new[]
    {
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 328,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 35118,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 98,
                    Time_Stamp = DateTime.Now
                },
                new {
                    Email = "tempemail@example.com",
                    Listing_Id = 1,
                    Amount = 8,
                    Time_Stamp = DateTime.Now
                },
            };

            var tempListings = new[] {
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 0, picture = "assets\\mock-data\\listing-images\\1.jpg", Description = "Description 0", Title = "Title 0", MaxBid = 500, Bids = tempBids0 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 1, picture = "assets\\mock-data\\listing-images\\2.jpg", Description = "Description 1", Title = "Title 1", MaxBid = 500, Bids = tempBids1 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 2, picture = "assets\\mock-data\\listing-images\\3.jpg", Description = "Description 2", Title = "Title 2" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 3, picture = "assets\\mock-data\\listing-images\\4.jpeg", Description = "Description 3", Title = "Title 3" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 4, picture = "assets\\mock-data\\listing-images\\5.jpg", Description = "Description 4", Title = "Title 4", MaxBid = 500, Bids = tempBids2  , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 5, picture = "assets\\mock-data\\listing-images\\6.jpg", Description = "Description 5", Title = "Title 5" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 6, picture = "assets\\mock-data\\listing-images\\7.jpg", Description = "Description 6", Title = "Title 6", MaxBid = 500, Bids = tempBids2  , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 7, picture = "assets\\mock-data\\listing-images\\8.jpg", Description = "Description 7", Title = "Title 7", MaxBid = 500, Bids = tempBids2  , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 8, picture = "assets\\mock-data\\listing-images\\9.jpg", Description = "Description 8", Title = "Title 8" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 9, picture = "assets\\mock-data\\listing-images\\10.jpg", Description = "Description 9", Title = "Title 9", MaxBid = 500, Bids = tempBids2  , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 10, picture = "assets\\mock-data\\listing-images\\11.jpg", Description = "Description 10", Title = "Title 10" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
                new { Start_Time = 0, End_Time = DateTime.Now, Number = 11, picture = "assets\\mock-data\\listing-images\\12.jpg", Description = "Description 11", Title = "Title 11" , MaxBid = 500, Bids = tempBids2 , Email = "tempemail@example.com" },
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
