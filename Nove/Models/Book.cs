using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nove.Models
{
    public class Book
    {
        public int Id { get; set; }
        public Collection collections { get; set; }

        public string userName { get; set; }
        public string bookName { get; set; }
        public string Url { get; set; }
        public bool states { get; set; }
        public int Rank { get; set; }

        public string bigImage { get; set; }
        public string smallImage { get; set; }

        public Sort sort { get; set; }
    }
}
