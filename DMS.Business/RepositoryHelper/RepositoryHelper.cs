using DMS.Data.Repository;
using DMS.Data.Repository.Interface;
using Unity;
using Unity.Extension;

namespace DMS.Business.RepositoryHelper
{
    public class RepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IDealerRepository, DealerRepository>();
        }
    }
}

