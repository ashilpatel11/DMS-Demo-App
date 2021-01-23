using DMS.Business;
using DMS.Business.Interface;
using DMS.Business.RepositoryHelper;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace DMS.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDealerManager, DealerManager>();
            container.AddNewExtension<RepositoryHelper>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}