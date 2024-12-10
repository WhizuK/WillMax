
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;

namespace WillMax.Applicatio.Service.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly IDataProtectionService _dataProtectionService;
        private readonly ITokenService _tokenService;

        public AccountService(IUserRepository userRepository, IDataProtectionService dataProtectionService, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _dataProtectionService = dataProtectionService;
            _tokenService = tokenService;
        }
        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = await _userRepository.GetByusername(loginRequestDto.Username);

            if (user == null) 
            {
                throw new Exception($"User {loginRequestDto.Username} not found!");
            }

            var hashedPassword = _dataProtectionService.GetComputedHash(loginRequestDto.Password, user.Account.SaltHash);

            for (int i = 0; i < hashedPassword.Length; i++)
            {
                if (hashedPassword[i] != user.Account.PasswordHash[i])
                {
                    throw new Exception("username or password incorrect");
                }
            }

            return new LoginResponseDto() { User = user, Token = _tokenService.GenerateToken(user) };
        }
    }
}
