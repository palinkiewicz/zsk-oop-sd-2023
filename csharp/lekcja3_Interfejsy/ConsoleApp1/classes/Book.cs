using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    internal class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public ushort Year { get; set; }
        public float Price {  get; set; }

        public Book(string title, string author, ushort year, float price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }

        override public string ToString()
        {
            return $"{Title}, {Author}, {Year}, {Price}";
        }
    }
}
