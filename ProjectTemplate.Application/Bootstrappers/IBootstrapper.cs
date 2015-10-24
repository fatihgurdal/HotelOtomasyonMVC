using ProjectTemplate.Core.IoC;

namespace ProjectTemplate.Application.Bootstrappers
{
    /// <summary>
    /// Bootstrapper interface
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Bootstraps and/or registersters dependencies using the given dependency container
        /// </summary>
        /// <param name="dependencyContainer"></param>
        void Bootstrap(IDependencyContainer dependencyContainer);
    }
}
