using Formula1Dashboard.Dtos.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Formula1Dashboard.Repositories
{
    public interface IDriverAppService : IApplicationService
    {
        Task<List<DriverDto>> GetAllDrivers();
    }
}
