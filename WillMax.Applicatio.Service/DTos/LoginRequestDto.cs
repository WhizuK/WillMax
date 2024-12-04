﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMax.Applicatio.Service.DTos
{
    public class LoginRequestDto
    {
        public LoginRequestDto(string username, string password) 
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
