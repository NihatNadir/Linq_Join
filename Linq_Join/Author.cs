using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Author(int yazarId,string isim) 
        {
            AuthorId = yazarId;
            Name = isim;
        }
    }
}
