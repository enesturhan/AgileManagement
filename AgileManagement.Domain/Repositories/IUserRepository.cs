using AgileManagement.Core;
using AgileManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Domain
{
    public  interface IUserRepository:IGenericRepository<ApplicationUser>
    {
        ApplicationUser FindUserByEmail(string email);
    }
}
