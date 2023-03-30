using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Formula1Dashboard.Entities.Drivers
{
    [Table("Driver", Schema = "dbo")]
    public class Driver : Entity<int>
    {
        public string DriverRef { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        [Column("url")]
        public string Url { get; set; }
        public string PictureLink { get; set; }
    }
}
