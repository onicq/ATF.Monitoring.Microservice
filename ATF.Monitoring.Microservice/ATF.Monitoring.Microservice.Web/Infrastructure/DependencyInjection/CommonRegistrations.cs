using ATF.Monitoring.Microservice.Data;
using ATF.Monitoring.Microservice.Web.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace ATF.Monitoring.Microservice.Web.Infrastructure.DependencyInjection
{
    /// <summary>
    /// Registrations for both points: API and Scheduler
    /// </summary>
    public partial class DependencyContainer
    {
        /// <summary>
        /// Register 
        /// </summary>
        /// <param name="services"></param>
        public static void Common(IServiceCollection services)
        {
            services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            // services
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ICacheService, CacheService>();
        }
    }


}
