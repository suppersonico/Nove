using Microsoft.AspNetCore.Identity;
using Nove.Data;
using Nove.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    public class BookServices:IBookServices
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public BookServices(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> UserManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = UserManager;
        }

        public void BookDel(int id)
        {
            var bookDel = _applicationDbContext.Books.FirstOrDefault(d => d.Id == id);
            if (bookDel!=null)
            {
                _applicationDbContext.Books.Remove(bookDel);
            }
            _applicationDbContext.SaveChanges();
        }

        public Book BookDetail(int id)
        {
            var count = _applicationDbContext.Books.Find(id);
            count.Rank += 1;
            _applicationDbContext.SaveChangesAsync();
            return _applicationDbContext.Books.Find(id);
        }

        public void BookPass(int id)
        {
            var bookDel = _applicationDbContext.Books.FirstOrDefault(d => d.Id == id);
            if (bookDel != null)
            {
                bookDel.states = true;
            }
            _applicationDbContext.SaveChanges();
        }

        public Task<IEnumerable<Book>> GetAllBooks()
        {
            return Task.Run(() => _applicationDbContext.Books.AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetAllManageBooks()
        {
            return Task.Run(() => _applicationDbContext.Books.Where(s => s.states == false).AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetBooksRank()
        {
            return Task.Run(() => _applicationDbContext.Books.OrderBy(r => r.Rank).AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetBooksRankTop3()
        {
            return Task.Run(() => _applicationDbContext.Books.OrderBy(r => r.Rank).Take(3).AsEnumerable());
        }

        public Task<IEnumerable<Book>> GetMyBooks(string userName)
        {
            return Task.Run(() => _applicationDbContext.Books.Where(u => u.userName == userName).AsEnumerable());
        }
    }
}
