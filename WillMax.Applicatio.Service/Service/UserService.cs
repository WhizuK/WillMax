
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

            await _unitOfWork.Commit(); // Aguarda o commit


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

        public Task<User> Delete(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<User> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _repository.GetByusername(username);
        }

        public Task<User> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}

