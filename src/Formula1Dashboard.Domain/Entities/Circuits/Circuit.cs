using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Formula1Dashboard.Entities.Circuits
{

    [Table("Circuit", Schema = "dbo")]
    public class Circuit : Entity<int>
    {
        public string CircuitRef { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Alt { get; set; }
        public string Url { get; set; }
        public string PictureLink { get; set; }
    }
}
