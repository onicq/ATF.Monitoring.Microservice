using ATF.Monitoring.Microservice.Data.Base;
using ATF.Monitoring.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace ATF.Monitoring.Microservice.Data
{
    /// <summary>
    /// Database for application
    /// </summary>
    public class ApplicationDbContext:DbContextBase<ApplicationDbContext>, IApplicationDbContext
    {
        /// <inheritdoc />
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #region System

        public DbSet<Log> Logs { get; set; }

        #endregion
    }
}