using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0072
{
    public interface IHasConfigureServices<out TServicesBuilder>
        where TServicesBuilder : IHasConfigureServices<TServicesBuilder>
    {
        TServicesBuilder ConfigureServices(Action<IServiceCollection> configureAction);
    }
}
