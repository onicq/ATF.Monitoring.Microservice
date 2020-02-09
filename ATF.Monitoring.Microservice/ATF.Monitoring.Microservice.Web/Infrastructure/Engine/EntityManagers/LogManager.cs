using AutoMapper;
using Calabonga.EntityFrameworkCore.UOW.Framework.Factories;
using Calabonga.EntityFrameworkCore.UOW.Framework.Managers;
using ATF.Monitoring.Microservice.Entities;
using ATF.Monitoring.Microservice.Web.Infrastructure.ViewModels.LogViewModels;
using Calabonga.Microservices.Core.Validators;

namespace ATF.Monitoring.Microservice.Web.Infrastructure.Engine.EntityManagers
{
    /// <summary>
    /// Entity manager for <see cref="Log"/>
    /// </summary>
    public class LogManager:EntityManager<LogViewModel, Log, LogCreateViewModel, LogUpdateViewModel>
    {
        /// <inheritdoc />
        public LogManager(IMapper mapper, IViewModelFactory<LogCreateViewModel, LogUpdateViewModel> viewModelFactory, IEntityValidator<Log> validator)
            : base(mapper, viewModelFactory, validator)
        {
        }
    }
}
