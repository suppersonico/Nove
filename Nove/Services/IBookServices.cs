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
        Book BookDetail(int id);
    }
}
