using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nove.Models;

namespace Nove.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Sort> Sorts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
