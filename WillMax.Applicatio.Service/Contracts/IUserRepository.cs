﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface IUserRepository : IRepository<User , Guid>
    {
        public Task<User> GetByusername(string username);
    }
}
