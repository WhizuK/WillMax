
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataProtectionService _dataProtectionService;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork, IDataProtectionService dataProtectionService)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _dataProtectionService = dataProtectionService;
        }


        public async Task<User> Create(RegisterRequestDto registerRequestDto)
        {
            var dataProtection = _dataProtectionService.Protect(registerRequestDto.Password);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = registerRequestDto.Name,
                Account = new Account
                {
                    Username = registerRequestDto.Username,
                    PasswordHash = dataProtection.PasswordHash,
                    SaltHash = dataProtection.PasswordSalt,
                }
            };

            _repository.Create(user);

            await _unitOfWork.Commit(); 


            return user;

            //var user = new User
            //{
            //    Id = Guid.NewGuid(),
            //    Name = registerRequestDto.Name,
            //    Account = new Account
            //    {
            //        Username = registerRequestDto.Username,
            //        PasswordHash = dataProtection.PasswordHash,
            //        SaltHash = dataProtection.PasswordSalt,
            //    }

            //};

            //_repository.Create(user);
            //_unitOfWork.Commit();
            //return await Task.FromResult(user);
        }

        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Delete(User user)
        {
            var entity = _repository.Delete(user);
            await _unitOfWork.Commit();
            return entity;
        }

        public  Task<User> Delete(Guid id)
        {
            var entity = _repository.DeleteById(id);
             _unitOfWork.Commit();
            return entity;

        }

        public Task<IEnumerable<User>> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _repository.GetByusername(username);
        }

        public async Task<User> Update(User user)
        {
            User user1 = new User();

            var entity = _repository.Update(user);
            await _unitOfWork.Commit();
            return entity;
        }
    }
}

