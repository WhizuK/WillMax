
using WillMax.Domain;
using Microsoft.AspNetCore.Http;


namespace WillMax.Applicatio.Service.DTos
{
    public class ApartmentRequestDto
    {
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        //public TypeListResponseDto? TypeList { get; set; }
        public LocationResponseDto? Location { get; set; }
        public string? Stats { get; set; }



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
            if (Image != null)
            {
                apartament.Image = !string.IsNullOrEmpty(Image) ? Image : "NoImage.jpg";
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

            if (Stats == null)
            {
                apartament.Stats = Stats;
            }
            if (Type == null)
            {
                apartament.Type = Type;
            }

            return apartament;
        }
    }
}
