
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> GetByUsername(string username);
    }
}
