﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}