using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Applicatio.Service.DTos;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface IAccountService
    {
        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
