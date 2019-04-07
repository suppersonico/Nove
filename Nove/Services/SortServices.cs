using Microsoft.EntityFrameworkCore;
using Nove.Data;
using Nove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    public class SortServices:ISortServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SortServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task<IEnumerable<Sort>> GetSorts()
        {
            return Task.Run(() => _applicationDbContext.Sorts.Include(s => s.Books).AsEnumerable());
        }
    }
}
