using DMS.BusinessEntities;
using DMS.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Repository
{
    public class DealerRepository : IDealerRepository
    {
        private Database.DMSContext dbContext;
        
        public DealerRepository()
        {
            dbContext = new Database.DMSContext();
        }

        
        public DealerViewModel GetDealer()
        {
            var dealerViewModel = new DealerViewModel();
            var dealerDetail = dbContext.Delers.FirstOrDefault(x => x.DelerID == 1);
            if(dealerDetail != null)
            {
                dealerViewModel.Id = dealerDetail.DelerID;
                dealerViewModel.DealerName = dealerDetail.DelerName;
            }
            return dealerViewModel;
        }
    }
}
