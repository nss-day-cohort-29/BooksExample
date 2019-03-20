using System;
using System.Collections.Generic;
using System.Linq;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book tomBook = new Book("Adventures of Tom Sawyer", 300);

            string title = tomBook.Title;
            int pageCount = tomBook.PageCount;
            string author = tomBook.Author;

            //tomBook.Title = "Huck Finn";

            tomBook.PageCount = 400;
            tomBook.PageCount = -27;

            Console.WriteLine($"The author is {author}");



            List<string> titles = new List<string>
            {
                "Official Book Club Selection",
                "Are You There, Vodka? It's Me, Chelsea",
                "When You Look Like Your Passport Photo, It's Time to Go Home",
                "Motherhood: The Second Oldest Profession",
                "I Owe Russia $1200",
                "Everything You Always Wanted to Know About Sex(But Were Afraid to Ask)",
                "Too Fat to Fish",
                "Politically Correct Bedtime Stories",
                "How to Teach Physics to Your Dog Intriguing",
                "Liberal Fascism",
                "People Who Eat Darkness",
                "Mine Enemy Grows Older",
                "Your Erroneous Zones",
                "Barbarians at the Gate",
                "Women Who Run With the Wolves",
                "Midnight In the Garden of Good and Evil",
                "The Devil In the White City",
                "Hot, Flat, and Crowded",
                "This Side of Innocence",
                "East of Eden",
                "The View from Pompey's Head",
                "Something of Value",
                "Ship of Fools",
                "The Spy Who Came in from the Cold",
                "Valley of the Dolls",
                "Looking for Mr.Goodbar",
                "How Stella Got Her Groove Back",
                "The Deep End of the Ocean",
                "Pretend You Don't See Her ",
            };

            /*
            List<Book> books = new List<Book>();
            foreach (string t in titles)
            {
                books.Add(new Book(t, 27));
            }
            */

            List<Book> books = titles
                .Select(t => new Book(t, t.Length * 100))
                .Where(b => b.PageCount > 2000)
                .OrderBy(taco => taco.Title)
                .ToList();

            foreach (string t in titles)
            {
                Console.WriteLine(t);
            }

            foreach (Book b in books)
            {
                Console.WriteLine($"Title: {b.Title}, PageCount: {b.PageCount}");
            }


            List<Book> books1 = (
                from t in titles
                select new Book(t, t.Length * 100)
            ).ToList();

            List<Book> filteredBooks = (from taco in books1
                                        where taco.PageCount > 2000
                                        orderby taco.Title
                                        select taco).ToList();

            Console.ReadKey();
        }
    }
}
