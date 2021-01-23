using DMS.Data.Repository.Interface;
using System.Collections.Generic;
using DMS.BusinessEntities;
using System;

namespace DMS.Data.Repository
{
    public class DealerRepository : IDealerRepository
    {
        public IList<DealerViewModel> GetDealerList()
        {
            IList<DealerViewModel> dealerList = new List<DealerViewModel>();

            var item1 = new DealerViewModel
            {
                Id = 1,
                DealerName = "D1",
                Address = "Address1",
                PhoneNo = "12345678"
            };
            dealerList.Add(item1);
            var item2 = new DealerViewModel
            {
                Id = 2,
                DealerName = "D2",
                Address = "Address2",
                PhoneNo = "12345678"
            };
            dealerList.Add(item2);
            var item3 = new DealerViewModel
            {
                Id = 3,
                DealerName = "D3",
                Address = "Address3",
                PhoneNo = "12345678"
            };
            dealerList.Add(item3);

            return dealerList;
        }

       
    }
}
