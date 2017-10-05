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
    public class UserInfoController : ApiController
    {

        private UserInfoDAL userInfoDal = new UserInfoDAL(); 

        // GET: api/UserInfo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserInfo/5
        [HttpGet]
        [Route("api/UserInfo/Get/{email}")]
        public UserInfo Get(string email)
        {
            return this.userInfoDal.GetUser(email);
        }

        // POST: api/UserInfo
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //this.userInfoDal.Add(value);
        }

        // PUT: api/UserInfo/5
        [HttpPut]
        public void Put(string email, [FromBody]string value)
        {
        }

        // DELETE: api/UserInfo/5
        [HttpDelete]
        public void Delete(String email)
        {
        }
    }
}
