using System;

namespace Code_First.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public String BookTitle { get; set; }
        public String Description { get; set; }
        public int AuthorID { get; set; }
        public double BookPrice { get; set; }
        public Author Author { get; set; }
    }
}