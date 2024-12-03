using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.DTos
{
    public class LocationResponseDto
    {
        public LocationResponseDto() { }
        public LocationResponseDto(Location location)
        {
            if (location == null)
            {
                Id = 0;
            }
            else
            {
                Id = 0;
                Name = location.Name;
            }
        }
        public int? Id { get; set; }
        public string? Name { get; set; }

    }
}
