
using WillMax.Domain;


namespace WillMax.Applicatio.Service.DTos
{
    public class ApartmentResponseDto
    {
        public ApartmentResponseDto() { }

        public ApartmentResponseDto(Apartament apartment)
        {
            Id = apartment.Id;
            Price = apartment.Price;
            Image = apartment.Image;
            Description = apartment.Description;
            Type = apartment.Type;
            Location = apartment.Location != null ? new LocationResponseDto(apartment.Location) : null;
            Stats = apartment.Stats;
        }


        public Guid? Id { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public LocationResponseDto? Location { get; set; }
        public string Stats { get; set; }
    }
}
