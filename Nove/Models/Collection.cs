using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public MyUser users { get; set; }
        public List<Book> books { get; set; }
    }
}
