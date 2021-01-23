using DMS.Business.Interface;
using DMS.BusinessEntities;
using DMS.Data.Repository.Interface;

namespace DMS.Business
{
    public class DealerManager : IDealerManager
    {
        private IDealerRepository DealerRepository { get; set; }

        public DealerManager(IDealerRepository dealerRepository)
        {
            DealerRepository = dealerRepository;
        }

        
        public DealerViewModel GetDealer()
        {
            return DealerRepository.GetDealer();
        }
    }
}
