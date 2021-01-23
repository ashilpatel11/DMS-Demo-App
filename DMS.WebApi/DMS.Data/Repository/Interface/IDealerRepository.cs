using DMS.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Data.Repository.Interface
{
    public interface IDealerRepository
    {
        DealerViewModel GetDealer();
    }
}
