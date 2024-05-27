using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering
{
    internal class Start
    {
        public List<Movie> Movies = new();
        public List<Book> Books = new();
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new entry");
                Console.WriteLine("2. Show an existing entry");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddEntry();
                }
                else if (userInput == "2")
                {
                    DisplayEntries();
                }
            }
        }

        public void DisplayEntries()
        {
            Console.Clear();
            Console.WriteLine("Would you like to see books or movies?");
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Books");

            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                ListMovies();
            }
            else if (userInput == "2")
            {
                ListBooks();
            }
        }

        public void NoEntries(string mediaType)
        {
            Console.Clear();
            Console.WriteLine($"There are no {mediaType} in your directory yet!");
            Console.Write("Press any key to continue..");
            Console.ReadKey();
        }

        public void ListBooks()
        {
            if (Books.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Which book would you like to see?");
                for (int i = 0; i < Books.Count; i++)
                {
                    var book = Books[i];
                    Console.WriteLine($"{i + 1}. {book.ShowTitle()}");
                }

                var userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput <= Books.Count)
                {
                    DisplayBook(Books[userInput - 1]);
                }
            }
            else
            {
                NoEntries("books");
            }
        }

        public void ListMovies()
        {
            if (Movies.Count > 0)
            {

                Console.Clear();
                Console.WriteLine("Which movie would you like to see?");
                for (int i = 0; i < Movies.Count; i++)
                {
                    var movie = Movies[i];
                    Console.WriteLine($"{i + 1}. {movie.ShowTitle()}");
                }

                var userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput <= Movies.Count)
                {
                    DisplayMovie(Movies[userInput - 1]);
                }
            }
            else
            {
                NoEntries("movies");
            }
        }

        public void AddEntry()
        {
            Console.Clear();
            Console.WriteLine("Hello, what would you like to add?");
            Console.WriteLine("1. Movie");
            Console.WriteLine("2. Book");


            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                AddMovie();
            }

            else if (userInput == "2")
            {
                AddBook();
            }
        }



        public void AddMovie()
        {
            Console.Clear();
            Console.WriteLine("What's the title of your movie?");
            var title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a description of your movie.");
            var description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the director of your movie?");
            var director = Console.ReadLine();
            Console.Clear();

            var actorState = true;
            List<string> actors = new List<string>();
            while (actorState)
            {
                Console.Clear();
                Console.WriteLine("Add an actor to your movie, or press 'c' to continue");
                var actor = Console.ReadLine();

                if (actor == "c")
                {
                    actorState = false;
                }
                else
                {
                    actors.Add(actor);
                }

            }
            Movie movie = new Movie(title, description, director, actors);

            Movies.Add(movie);
        }

        public void AddBook()
        {
            Console.Clear();
            Console.WriteLine("What's the title of your book?");
            string title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a description of your book.");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the author of your book?");
            string author = Console.ReadLine();
            Console.Clear();

            Book book = new Book(title, author, description);

            Books.Add(book);
        }

        public void DisplayMovie(Movie movie)
        {
            Console.Clear();
            Console.WriteLine($"{movie.ShowTitle()} by {movie.ShowDirector()}");
            Console.WriteLine($"{movie.ShowDesc()}");
            Console.WriteLine();
            Console.WriteLine("Actors:");
            foreach (var actor in movie.ShowActors())
            {
                Console.WriteLine(actor);
            }
            Console.Write("Press any key to continue..");
            Console.ReadKey();
        }

        public void DisplayBook(Book book)
        {
            Console.Clear();
            Console.WriteLine($"{book.ShowTitle()} by {book.ShowAuthor()}");
            Console.WriteLine($"{book.ShowDesc()}");
            Console.Write("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
