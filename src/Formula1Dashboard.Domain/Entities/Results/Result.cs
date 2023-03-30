using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Formula1Dashboard.Entities.Results
{
    [Table("Result", Schema = "dbo")]
    public class Result : Entity<int>
    {
        public int RaceId { get; set; }
        public int? DriverId { get; set; }
        public int ConstructorId { get; set; }
        public string Number { get; set; }
        public int Grid { get; set; }
        public string Position { get; set; }
        public string PositionText { get; set; }
        public int? PositionOrder { get; set; }
        public string Points { get; set; }
        public string Laps { get; set; }
        public string Time { get; set; }
        public string Milliseconds { get; set; }
        public string FastestLap { get; set; }
        public string Rank { get; set; }
        public string FastestLapTime { get; set; }
        public string FastestLapSpeed { get; set; }
        public int? StatusId { get; set; }
    }
}
