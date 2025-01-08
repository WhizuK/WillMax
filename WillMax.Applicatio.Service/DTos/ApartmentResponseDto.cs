
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
            TypeList = apartment.TypeListing ;
            Location = apartment.Location != null ? new LocationResponseDto(apartment.Location) : null;
            Stats = apartment.Stats;
        }


        public Guid? Id { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public TypeListing TypeList { get; set; }
        public LocationResponseDto? Location { get; set; }
        public Stats Stats { get; set; }
    }
}
