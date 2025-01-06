using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMax.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }    
        public List<UserRole> Roles { get; set; } = [UserRole.ROLE_ADMIN];
    }
}
