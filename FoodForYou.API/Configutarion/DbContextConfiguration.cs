using FoodForYou.Api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace FoodForYou.API.Configutarion
{
    public static class DbContextConfiguration
    {
        public static IServiceCollection SolveDbContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            var stringConnection = configuration.GetConnectionString("FoodForYouDB");
            services.AddDbContext<FFYDbContext>(options =>
            {
                options.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection));
            });
            return services;
        }
    }
}