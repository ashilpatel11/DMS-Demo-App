using DMS.Business.Interface;
using DMS.BusinessEntities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DMS.WebAPI.Controllers
{

    public class DealerController : ApiController
    {
        private IDealerManager DealerManager { get; set; }
        public DealerController(IDealerManager dealerManager)
        {
            DealerManager = dealerManager;
        }
        [HttpGet]
        public HttpResponseMessage GetDealerList()
        {
            IList<DealerViewModel> dealerList = DealerManager.GetDealerList();
            return Request.CreateResponse(HttpStatusCode.OK, dealerList);
        }
    }
}
