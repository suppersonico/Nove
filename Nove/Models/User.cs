using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Models
{
    public class MyUser
    {
        public int Id { get; set; }
        public IEnumerable<Collection> collections { get; set; }

        public IdentityUser identityUser { get; set; }
        public string password { get; set; }
        public int permissionLevel { get; set; }
    }
}
