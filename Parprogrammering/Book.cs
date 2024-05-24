using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering
{
    internal class Book
    {
        private string Title;
        private string Author;
        private string Description;

        public Book(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public string ShowTitle()
        {
            return Title;
        }
        public string ShowAuthor()
        {
            return Author;
        }
        public string ShowDesc()
        {
            return Description;
        }
    }
}
