using Formula1Dashboard.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Formula1Dashboard.Repositories
{
    public interface IRaceResultAppService : IApplicationService
    {
        Task<List<RaceResultDto>> GetResultsByDriverId(int driverId);
        Task<List<RaceResultPointsDto>> GetRaceResultPointsByDriverId(int driverId);
    }
}
