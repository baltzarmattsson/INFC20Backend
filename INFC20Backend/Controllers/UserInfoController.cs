using infc20.DataAccessLayer;
using infc20.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace infc20.Controllers
{
    public class UserInfoController : ApiController
    {

        private UserDAL userInfoDal = new UserDAL(); 

        // GET: api/UserInfo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserInfo/5
        [HttpGet]
        [Route("api/UserInfo/Get/{email}")]
        public User Get(string email)
        {
            return null;
            //return this.userInfoDal.GetUser(email);
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
