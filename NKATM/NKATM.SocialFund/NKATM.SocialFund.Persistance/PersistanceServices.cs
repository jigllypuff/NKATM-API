using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NKATM.SocialFund.Application.Persistance.Contracts;
using NKATM.SocialFund.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Persistance
{
    public static class PersistanceServices
    {
        public static IServiceCollection ConfigurePersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SocialFundDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

            services.AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>));
            services.AddScoped<ISocialTypeRepository, SocialTypeRepository>();
            services.AddScoped<ISocialRequestRepository, SocialRequestRepository>();
            services.AddScoped<ISocialResultRepository, SocialResultRepository>();

            return services;
        }
    }
}
