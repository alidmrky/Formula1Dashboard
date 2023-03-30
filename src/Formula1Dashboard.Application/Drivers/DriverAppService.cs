using Formula1Dashboard.Dtos.Drivers;
using Formula1Dashboard.Entities.Drivers;
using Formula1Dashboard.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Formula1Dashboard.Drivers
{
    public class DriverAppService : ApplicationService, IDriverAppService
    {
        private readonly DriverManager _driverManager;
        public DriverAppService(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public async Task<List<DriverDto>> GetAllDrivers()
        {
            var drivers = await _driverManager.GetAllDrivers();
            return ObjectMapper.Map<List<Driver>, List<DriverDto>>(drivers);
        }
    }
}
