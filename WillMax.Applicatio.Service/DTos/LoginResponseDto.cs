using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.DTos
{
    public class LoginResponseDto
    {
        public User User { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
     
    }
}
