using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Formula1Dashboard.Entities.Constructors
{
    [Table("Constructor", Schema = "dbo")]
    public class Constructor : Entity<int>
    {
        public string ConstructorRef { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Url { get; set; }
        public string PictureLink { get; set; }
    }
}
