using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Formula1Dashboard.Dtos.Drivers
{
    public class DriverDto : EntityDto<int>
    {
        public string DriverRef { get; set; }
        public string Number { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Url { get; set; }
        public string PictureLink { get; set; }
    }
}
