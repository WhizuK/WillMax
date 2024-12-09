
//using Microsoft.EntityFrameworkCore;
//using WillMax.Applicatio.Service.Contracts;
//using WillMax.Domain;

//namespace WillMax.Infra.Dta.Repository
//{
//    public class UserRepository : Repository<User, Guid>, IUserRepository
//    {
//        public UserRepository(ApplicationDbContext context) : base(context)
//        {
//        }


//        public async Task<User?> GetByusername(string username)
//        {
//            return DbSet
//                .Include(x => x.Account)
//                .FirstOrDefault(x => x.Account.Username == username);

//        }
//    }
//}
