using Nove.Data;
using Nove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    public class BookServices:IBookServices
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BookServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public Task<IEnumerable<Book>> GetAllBooks()
        {
            return Task.Run(() => _applicationDbContext.Books.AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetBooksRank()
        {
            return Task.Run(() => _applicationDbContext.Books.OrderBy(r => r.Rank).AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetBooksRankTop3()
        {
            return Task.Run(() => _applicationDbContext.Books.OrderBy(r => r.Rank).Take(3).AsEnumerable());
        }
    }
}
