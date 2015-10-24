using System;

namespace ProjectTemplate.Core.IoC
{
    /// <summary>
    /// The IoC container interface
    /// </summary>
    public interface IDependencyContainer
    {
        /// <summary>
        /// Registers a service implementation for the given  service type withe given scope
        /// </summary>
        /// <param name="serviceType">The service type</param>
        /// <param name="classType">The service implementation type</param>
        /// <param name="scope">Scope of registration</param>
        /// <param name="singleton">Singleton instance if scope is singleton</param>
        /// <returns></returns>
        IDependencyContainer Register(Type serviceType, Type classType, DependencyScope scope = DependencyScope.Transient, object singleton = null);

        /// <summary>
        /// Resolves and returns instance of implementation for the requested service type
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        object Resolve(Type serviceType);
    }

    /// <summary>
    /// Dependency container extensions
    /// </summary>
    public static class DependencyContainerExtensions
    {
        /// <summary>
        /// Registers a trasient service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterTransient<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass));
        }

        /// <summary>
        /// Registers a per thread service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterPerThread<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.PerThread);
        }

        /// <summary>
        /// Registers a per web request service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterPerWebRequest<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.PerWebRequest);
        }

        /// <summary>
        /// Registers a singleton service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterSingleton<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.Singleton);
        }

        /// <summary>
        /// Registers a singleton service implementation for the given type withe given instance
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="prov"></param>
        /// <param name="singleton"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterSingleton<TInterface>(this IDependencyContainer prov, TInterface singleton)
        {
            return prov.Register(typeof(TInterface), singleton.GetType(), DependencyScope.Singleton, singleton);
        }

        /// <summary>
        /// Resolves and casts service implementation
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static TInterface Resolve<TInterface>(this IDependencyContainer prov)
        {
            return (TInterface)prov.Resolve(typeof(TInterface));
        }
    }
}
