using Microsoft.AspNetCore.Identity;
using Nove.Data;
using Nove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    public class UserServices:IUserServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserServices(ApplicationDbContext noveContext)
        {
            _applicationDbContext = noveContext;
        }

        
    }
}
