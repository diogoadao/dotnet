using System;
using System.Collections.Generic;

namespace Code_First.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public String AuthorName { get; set; }
        public String EmailID { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}