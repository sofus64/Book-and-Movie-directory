using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering
{
    internal class Movie
    {
        public string Title;
        public string Description;
        public string Director;
        public List<string> Actors;

        public Movie(string title, string description, string director, List<string> actors)
        {
            Title = title;
            Description = description;
            Director = director;
            Actors = actors;
        }
    }
       
}
