using Microsoft.Extensions.DependencyInjection;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Services;
using SportsShop.Domain.Interfaces;
using SportsShop.Infra.Data.Repository;

namespace SportsShop.Infra.IoC
{
    public class DependencyContainer
    {
        //Dependency Injection 
        public static void RegisterServices(IServiceCollection service)
        {
            #region Application Layer

            service.AddScoped<IPermissionService, PermissionService>();
            service.AddScoped<IUserService, UserService>();
            #endregion

            #region Infra Data Layer

            service.AddScoped<IPermissionRepository, PermissionRepository>();
            service.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }
}
