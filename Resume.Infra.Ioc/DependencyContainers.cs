using Microsoft.Extensions.DependencyInjection;
using Resume.Application.Services.Implementations;
using Resume.Application.Services.Interfaces;


namespace Resume.Infra.Ioc
{
    public class DependencyContainers
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<IThingIDoService, ThingIDoService>();
        }
    }
}
