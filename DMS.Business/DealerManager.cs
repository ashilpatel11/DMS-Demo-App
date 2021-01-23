using DMS.Business.Interface;
using DMS.BusinessEntities;
using DMS.Data.Repository.Interface;
using System.Collections.Generic;

namespace DMS.Business
{
    public class DealerManager : IDealerManager
    {
        private IDealerRepository DealerRepository { get; set; }


        public DealerManager(IDealerRepository dealerRepository)
        {
            DealerRepository = dealerRepository;
        }

        public IList<DealerViewModel> GetDealerList()
        {
            return DealerRepository.GetDealerList();
        }
    }
}
