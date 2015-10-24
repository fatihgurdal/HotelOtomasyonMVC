using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ProjectTemplate.Application.Bootstrappers;
using ProjectTemplate.Core.IoC;
using WebApplication1.Controllers;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            


            //IoC Register !!!!
            Bootstrapper.Instance.Bootstrap(new DependencyBootstrapper());

            //IoC Resolver !!!!
            var dependencyContainer = DependencyContainer.Current;

            var controllersAssembly = typeof(BaseController).Assembly;
            foreach (var controllerType in controllersAssembly.GetTypes().Where(t => typeof(BaseController).IsAssignableFrom(t) || typeof(Controller).IsAssignableFrom(t)))
            {
                dependencyContainer.Register(controllerType, controllerType);
            }

            DependencyResolver.SetResolver(new UIDependecyResolver());
        }
    }
    public class UIDependecyResolver : IDependencyResolver
    {
        private readonly IDependencyResolver _resolver = DependencyResolver.Current;

        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return DependencyContainer.Current.Resolve(serviceType);
            }
            return _resolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return new[] { DependencyContainer.Current.Resolve(serviceType) };
            }
            return _resolver.GetServices(serviceType);
        }
    }

}
