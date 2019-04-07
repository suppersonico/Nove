using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Models
{
    public class Sort
    {
        public int Id { get; set; }

        public IEnumerable<Book> Books { get; set; }
        public string sortName { get; set; }
    }
}
