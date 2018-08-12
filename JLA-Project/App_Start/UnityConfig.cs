using JLA_Project.Models;
using JLA_Project.Repositories;
using JLA_Project.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace JLA_Project
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IClientService, ClientService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ISupplierService, SupplierService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<MyContextDB, MyContextDB>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}