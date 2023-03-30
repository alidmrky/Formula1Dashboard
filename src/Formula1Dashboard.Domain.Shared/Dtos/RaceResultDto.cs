using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1Dashboard.Dtos
{
    public class RaceResultDto
    {
        public string Year { get; set; }
        public List<RaceResultDetailDto> Detail { get; set; }

    }
    public class RaceResultDetailDto
    {
        public string GrandPrixName { get; set; }
        public string CircuitPictureUrl { get; set; }
        public DateTime? RaceDate { get; set; }
        public string Position { get; set; }
        public string FastestLapTime { get; set; }
    }
}
