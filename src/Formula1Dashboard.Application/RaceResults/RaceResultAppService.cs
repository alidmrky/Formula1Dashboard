using Formula1Dashboard.Dtos;
using Formula1Dashboard.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Formula1Dashboard.RaceResults
{
    public class RaceResultAppService : ApplicationService, IRaceResultAppService
    {
        private readonly RaceResultManager _raceResultManager;
        public RaceResultAppService(RaceResultManager raceResultManager)
        {
            _raceResultManager = raceResultManager;
        }

        public async Task<List<RaceResultPointsDto>> GetRaceResultPointsByDriverId(int driverId)
        {
            return await _raceResultManager.GetRaceResultPointsByDriverId(driverId);
        }

        public async Task<List<RaceResultDto>> GetResultsByDriverId(int driverId)
        {
            return await _raceResultManager.GetResultsByDriverId(driverId);
        }
    }
}
