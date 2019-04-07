using Nove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    interface IUserServices
    {
        Task<MyUser> sign(MyUser model);
        Task Register(MyUser model);
    }
}
