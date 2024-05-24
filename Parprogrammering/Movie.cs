using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering
{
    internal class Movie
    {
        private string Title;
        private string Description;
        private string Director;
        private List<string> Actors;

        public Movie(string title, string description, string director, List<string> actors)
        {
            Title = title;
            Description = description;
            Director = director;
            Actors = actors;
        }

        public string ShowTitle()
        {
            return Title;
        }
        public string ShowDirector()
        {
            return Director;
        }
        public string ShowDesc()
        {
            return Description;
        }

        public List<string> ShowActors()
        {
            return Actors;
        }
    }
}
