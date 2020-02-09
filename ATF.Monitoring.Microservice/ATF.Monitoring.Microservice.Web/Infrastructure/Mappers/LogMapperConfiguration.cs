using Calabonga.EntityFrameworkCore.UOW;
using ATF.Monitoring.Microservice.Entities;
using ATF.Monitoring.Microservice.Web.Infrastructure.Mappers.Base;
using ATF.Monitoring.Microservice.Web.Infrastructure.ViewModels.LogViewModels;

namespace ATF.Monitoring.Microservice.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Log
    /// </summary>
    public class LogMapperConfiguration:MapperConfigurationBase
    {
        /// <inheritdoc />
        public LogMapperConfiguration()
        {
            CreateMap<LogCreateViewModel, Log>()
                .ForMember(x => x.Id, o => o.Ignore());

            CreateMap<Log, LogViewModel>();

            CreateMap<IPagedList<Log>, IPagedList<LogViewModel>>()
                .ConvertUsing<PagedListConverter<Log, LogViewModel>>();
        }
    }
}
