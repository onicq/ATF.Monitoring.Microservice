using AutoMapper;

namespace ATF.Monitoring.Microservice.Web.Infrastructure.Mappers.Base
{

    /// <summary>
    /// Base class for mapper configuration.
    /// All ViewModel that will be mapped should implement IAutoMapper
    /// </summary>
    public abstract class MapperConfigurationBase:Profile, IAutoMapper { }
}
