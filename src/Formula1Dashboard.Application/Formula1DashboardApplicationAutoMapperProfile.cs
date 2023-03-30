using AutoMapper;
using Formula1Dashboard.Dtos.Drivers;
using Formula1Dashboard.Entities.Drivers;

namespace Formula1Dashboard;

public class Formula1DashboardApplicationAutoMapperProfile : Profile
{
    public Formula1DashboardApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Driver, DriverDto>();
    }
}
