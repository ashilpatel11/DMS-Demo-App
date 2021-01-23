using DMS.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DMS.WebApi.Controllers
{
    public class DealerController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        private IDealerManager DealerManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dealerManager"></param>
        public DealerController(IDealerManager dealerManager)
        {
            DealerManager = dealerManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetDealer()
        {
            var dealerDetail = DealerManager.GetDealer();
            return Request.CreateResponse(HttpStatusCode.OK, dealerDetail);
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
