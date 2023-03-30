using Formula1Dashboard.Dtos.Drivers;
using Formula1Dashboard.Repositories;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Formula1Dashboard.Blazor.Pages.Drivers
{
    public partial class DriverComponent
    {
        [Inject]private IDriverAppService _driverAppService { get; set; }
        public List<DriverDto> DriverDtos { get; set; } = new List<DriverDto>();
        public int SelectedDriver { get; set; }
        protected override async Task OnInitializedAsync()
        {
            DriverDtos = await _driverAppService.GetAllDrivers();
        }
    }
}
