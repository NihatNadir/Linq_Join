using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public Book(int id , string baslik , int yazarId) 
        {
            BookId = id ;
            Title = baslik ;
            AuthorId = yazarId ;
        }
    }
}
