using System.Reflection;
using Ninject.Extensions.Factory;

namespace Rps.Infrastructure.IoC
{
    /// <summary>
    ///     The standard implementation of the instance provider for a given name
    /// </summary>
    public class NameInstanceProvider : StandardInstanceProvider
    {
        /// <summary>
        ///     Gets the name that shall be used to request an instance for the specified
        ///     method and arguments. Null if unnamed instances shall be requested.
        /// </summary>
        /// <param name="methodInfo">The method info of the method that was called on the factory.</param>
        /// <param name="arguments">The arguments that were passed to the factory.</param>
        /// <returns>
        ///     The name that shall be used to request an instance for the specified method
        ///     and arguments. Null if unnamed instances shall be requested.
        /// </returns>
        protected override string GetName(MethodInfo methodInfo, object[] arguments)
        {
            return (string)arguments[0];
        }
    }
}