using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.DTos
{
    public class ApartmentRequestDto
    {
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public LocationResponseDto? Location { get; set; }


        public Apartament ToEntity()
        {
            Apartament apartament = new Apartament();
            if (Price == null || Price == 00)
            {
                apartament.Price = 0;
                
            } else
            {
                apartament.Price = Price.Value;
            }
            if (string.IsNullOrEmpty(Image))
            {
                apartament.Image = "NoImage.jpg";
            } else
            {
                apartament.Image = apartament.Image;
            }
            if (!string.IsNullOrEmpty(Description))
            {
                apartament.Description = "Description ????";
            } else
            {
                apartament.Description = Description;
            }
            if (Location == null)
            {
                Location location = new Location();
                location.Id = 0;
                apartament.Location = location;
            } else
            {
                Location location = new Location();
                apartament.Location = location;
                location.Id = apartament.Location.Id;
                location.Name = apartament.Location.Name;
            }
            return apartament;
        }
    }
}
