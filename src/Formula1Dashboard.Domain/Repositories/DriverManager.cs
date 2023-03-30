using Formula1Dashboard.Entities.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Formula1Dashboard.Repositories
{
    public class DriverManager : IDomainService
    {
        private readonly IRepository<Driver> _driverRepository;
        public DriverManager(IRepository<Driver> driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<List<Driver>> GetAllDrivers()
        {
            return await _driverRepository.GetListAsync();
        }
    }
}
