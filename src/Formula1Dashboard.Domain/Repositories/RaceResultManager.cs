using Formula1Dashboard.Dtos;
using Formula1Dashboard.Entities.Circuits;
using Formula1Dashboard.Entities.Drivers;
using Formula1Dashboard.Entities.Races;
using Formula1Dashboard.Entities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace Formula1Dashboard.Repositories
{
    public class RaceResultManager : IDomainService
    {
        private readonly IRepository<Driver> _driverRepository;
        private readonly IRepository<Race> _raceRepository;
        private readonly IRepository<Result> _resultRepository;
        private readonly IRepository<Circuit> _circuitRepository;
        public RaceResultManager(IRepository<Driver> driverRepository, IRepository<Race> raceRepository, IRepository<Result> resultRepository, IRepository<Circuit> circuitRepository)
        {
            _driverRepository = driverRepository;
            _raceRepository = raceRepository;
            _resultRepository = resultRepository;
            _circuitRepository = circuitRepository;
        }

        public async Task<List<RaceResultDto>> GetResultsByDriverId(int driverId)
        {
            var races = await _raceRepository.GetQueryableAsync();
            var results = await _resultRepository.GetQueryableAsync();
            var circuits = await _circuitRepository.GetQueryableAsync();

            var query = (from _races in races
                         join _results in results on _races.Id equals _results.RaceId
                         join _circuits in circuits on _races.CircuitId equals _circuits.Id
                         where _results.DriverId == driverId
                         select new
                         {
                             Year = _races.Year,
                             Name = _races.Name,
                             RaceDate = _races.Date,
                             Position = _results.Position,
                             PictureLink = _circuits.PictureLink,
                             FastestLapTime = _results.FastestLapTime
                         }).ToList();
            var raceResult = query.GroupBy(x => x.Year).Select(group => new RaceResultDto()
            {
                Year = group.Key.ToString()
            });
            raceResult = raceResult.Select(r => new RaceResultDto()
            {
                Year = r.Year,
                Detail = query.Where(x => x.Year == int.Parse(r.Year)).Select(x => new RaceResultDetailDto()
                {
                    CircuitPictureUrl = x.PictureLink,
                    FastestLapTime = x.FastestLapTime,
                    GrandPrixName = x.Name,
                    Position = x.Position,
                    RaceDate = x.RaceDate,
                }).ToList()
            });
            return await Task.FromResult(raceResult.ToList());
        }
        public async Task<List<RaceResultPointsDto>> GetRaceResultPointsByDriverId(int driverId)
        {
            var races = await _raceRepository.GetQueryableAsync();
            var results = await _resultRepository.GetQueryableAsync();

            var query = (from _races in races
                         join _results in results on _races.Id equals _results.RaceId
                         where _results.DriverId == driverId
                         select new
                         {
                             Year = _races.Year,
                             Points = Convert.ToDecimal(_results.Points)
                         }).ToList();
            var raceResultPoints = query.GroupBy(x => x.Year)
                .Select(x => new RaceResultPointsDto()
                {
                    Year = x.Key.ToString(),
                    Points = x.Sum(x=>x.Points)
                }).ToList();

            return raceResultPoints;
        }
    }
}
