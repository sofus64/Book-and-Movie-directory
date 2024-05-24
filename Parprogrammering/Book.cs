using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string Description;

        public Book(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }
    }
}
