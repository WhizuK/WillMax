using Microsoft.EntityFrameworkCore;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Domain;

namespace WillMax.Infra.Dta.Repository
{
    public class ApartmentRepository : Repository<Apartament, Guid>, IApartamentRepository
    {
        public ApartmentRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Apartament> GetApartamentByLocation(Guid apartmentId, CancellationToken ct)
        {
            return await DbSet.Include(apt => apt.Location).FirstOrDefaultAsync(apt => apt.Id == apartmentId, ct);
        }
    }
}
