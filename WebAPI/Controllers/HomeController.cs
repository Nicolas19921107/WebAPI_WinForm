using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("HomeWork")]
        // GET api/values
        /// <summary>
        /// GET 所有資料
        /// </summary>
        /// <returns></returns>   
        public string SimpleBinding(string Name, int Age)
        {
            return nameof(Name) + ":" + Name + ", " + nameof(Age) + ":" + Age;
        }

        // GET api/values/5
        /// <summary>
        /// Get 單一資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// POST 單一資料
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string Name,string Age)
        {
           
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
