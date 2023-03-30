using Blazorise.Charts;
using Formula1Dashboard.Dtos;
using Formula1Dashboard.Repositories;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1Dashboard.Blazor.Pages.RaceResults
{
	public partial class RaceResultPointsByYearComponent
	{
		LineChart<decimal> lineChart;

		[Inject] private IRaceResultAppService _raceResultAppService { get; set; }
		[Inject] private IDriverAppService _driverAppService { get; set; }
		[Parameter] public int? DriverId { get; set; } = null;
		public List<RaceResultPointsDto> RaceResultPoints { get; set; } = new List<RaceResultPointsDto>();
		public string[] Labels { get; set; }
		protected override async Task OnInitializedAsync()
		{
			int selectedDriver = 0;
			if (DriverId == null || DriverId == 0)
			{
				var drivers = await _driverAppService.GetAllDrivers();
				selectedDriver = drivers.First().Id;
			}
			else
			{
				selectedDriver = DriverId.Value;
			}
			RaceResultPoints = await _raceResultAppService.GetRaceResultPointsByDriverId(selectedDriver);
		}
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				await HandleRedraw();
			}
		}
		protected override async Task OnParametersSetAsync()
		{
			int selectedDriver = 0;
			if (DriverId == null || DriverId == 0)
			{
				var drivers = await _driverAppService.GetAllDrivers();
				selectedDriver = drivers.First().Id;
			}
			else
			{
				selectedDriver = DriverId.Value;
			}
			RaceResultPoints = await _raceResultAppService.GetRaceResultPointsByDriverId(selectedDriver);
			RaceResultPoints = RaceResultPoints.OrderBy(x => x.Year).ToList();
			Labels = RaceResultPoints.Select(x => x.Year).ToArray();

			if (lineChart != null)
			{
				await HandleRedraw();
			}
		}
		async Task HandleRedraw()
		{
			await lineChart.Clear();

			await lineChart.AddLabelsDatasetsAndUpdate(Labels, GetLineChartDataset());
		}
		LineChartDataset<decimal> GetLineChartDataset()
		{
			return new LineChartDataset<decimal>
			{
				Data = RaceResultPoints.Select(x => x.Points).ToList(),
				Label = "Total Point",
			};
		}
	}
}
