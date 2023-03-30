using Formula1Dashboard.Dtos;
using Formula1Dashboard.Repositories;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1Dashboard.Blazor.Pages.RaceResults
{
    public partial class RaceResultByDriverIdComponent
    {
        private readonly IRaceResultAppService _raceResultAppService;

        private readonly IDriverAppService _driverAppService;
        public List<RaceResultDto> RaceResultDtos { get; private set; }
        public List<string> TabYears { get; private set; }
        public string SelectedTab { get; private set; } = string.Empty;
        [Parameter] public int? DriverId { get; set; } = null;
        public RaceResultByDriverIdComponent(IRaceResultAppService raceResultAppService, IDriverAppService driverAppService)
        {
            _raceResultAppService = raceResultAppService;
            _driverAppService = driverAppService;
            RaceResultDtos = new List<RaceResultDto>();
            TabYears = new List<string>();
        }
        protected override async Task OnInitializedAsync()
        {
            await LoadRaceResultAsync();
        }
        protected override async Task OnParametersSetAsync()
        {
            await LoadRaceResultAsync();
        }
        private async Task LoadRaceResultAsync()
        {
            int selectedDriverId = DriverId ?? (await _driverAppService.GetAllDrivers()).First().Id;
            RaceResultDtos = await _raceResultAppService.GetResultsByDriverId(selectedDriverId);
            TabYears = RaceResultDtos.Select(r => r.Year.ToString()).ToList();
            SelectedTab = RaceResultDtos.FirstOrDefault()?.Year.ToString() ?? string.Empty;
        }
    }
}
