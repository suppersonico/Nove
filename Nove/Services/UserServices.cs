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

        public Task Register(MyUser Model)
        {
            _applicationDbContext.Add(Model);
            return Task.CompletedTask;
        }

        public Task<MyUser> sign(MyUser model)
        {
            if ((_applicationDbContext.MyUsers.FirstOrDefault(u => u.userName == model.userName)) != null && (_applicationDbContext.MyUsers.FirstOrDefault(u => u.password == model.password)) != null)
            {
                return Task.Run(() => model);
            }
            else
            {
                return null;
            }
        }
    }
}
