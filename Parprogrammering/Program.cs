namespace Parprogrammering
{
    internal class Program
    {
        public static List<Movie> Movies = new List<Movie>();
        public static List<Book> Books = new List<Book>();

        static void Main(string[] args)
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

        static void DisplayEntries()
        {
            Console.Clear();
            Console.WriteLine("Would you like to see books or movies?");
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Books");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                ListMovies();
            }
            else if (userInput == "2")
            {
                ListBooks();
            }
        }

        static void ListBooks()
        {
            Console.Clear();
            Console.WriteLine("Which book would you like to see?");
            for (int i = 0; i < Books.Count; i++)
            {
                var book = Books[i];
                Console.WriteLine($"{i+1}. {book.Title}");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());
            

            if (userInput <= Books.Count)
            {
                DisplayBook(Books[userInput-1]);
            }

        }

        static void ListMovies()
        {
            Console.Clear();
            Console.WriteLine("Which movie would you like to see?");
            for (int i = 0; i < Movies.Count; i++)
            {
                var movie = Movies[i];
                Console.WriteLine($"{i + 1}. {movie.Title}");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());


            if (userInput <= Movies.Count)
            {
                DisplayMovie(Movies[userInput - 1]);
            }
        }

        static void AddEntry()
        {
            Console.Clear();
            Console.WriteLine("Hello, what would you like to add?");
            Console.WriteLine("1. Movie");
            Console.WriteLine("2. Book");


            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                AddMovie();
            }

            else if (userInput == "2")
            {
                AddBook();
            }
        }



        static void AddMovie()
        {
            Console.Clear();
            Console.WriteLine("What's the title of your movie?");
            string title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a description of your movie.");
            string description = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the director of your movie?");
            string director = Console.ReadLine();
            Console.Clear();

            bool actorState = true;
            string actor = "";
            List<string> actors = new List<string>();
            while (actorState) {
                Console.Clear();
                Console.WriteLine("Add an actor to your movie, or press 'c' to continue");
                actor = Console.ReadLine();

                if(actor == "c")
                {
                    actorState = false;
                } else
                {
                    actors.Add(actor);
                }

            }
            Movie movie = new Movie(title, description, director, actors);

            Movies.Add(movie);
        }

        static void AddBook()
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

            Book book = new Book(title, description, author);

            Books.Add(book);
        }

        static void DisplayMovie(Movie movie)
        {
            Console.Clear();
            Console.WriteLine($"{movie.Title} by {movie.Director}");
            Console.WriteLine($"{movie.Description}");
            Console.WriteLine();
            Console.WriteLine("Actors:");
            foreach (var actor in movie.Actors)
            {
                Console.WriteLine(actor);
            }
            Console.Write("Press any key to continue..");
            Console.ReadKey();
        }

        static void DisplayBook(Book book)
        {
            Console.Clear();
            Console.WriteLine($"{book.Title} by {book.Author}");
            Console.WriteLine($"{book.Description}");
            Console.Write("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
