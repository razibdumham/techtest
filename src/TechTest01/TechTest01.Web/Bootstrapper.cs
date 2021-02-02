using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TechTest01.Repository;
using TechTest01.Services.Catalog;
using Unity.Mvc3;

namespace TechTest01.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }


        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductService, ProductService>();

            return container;
        }
    }
}