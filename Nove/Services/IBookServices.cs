using Nove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Services
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<IEnumerable<Book>> GetBooksRank();
        Task<IEnumerable<Book>> GetBooksRankTop3();
        Task<IEnumerable<Book>> GetMyBooks(string userName);
        Task<IEnumerable<Book>> GetAllManageBooks();
        Book BookDetail(int id);
        void BookDel(int id);
        void BookPass(int id);
    }
}
