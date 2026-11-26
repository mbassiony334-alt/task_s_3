using System.Text;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
              both title and upperTitle to show that title did not change.
            */
            string title = "clean code";
            Console.WriteLine(title);
            Console.WriteLine(title.ToUpper());

            /*
             */
            string mes1 = "clean code";
            string mes2 = "clean code";
            Console.WriteLine(mes1.Equals(mes2));
            Console.WriteLine(ReferenceEquals(mes1,mes2));

            /*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
                object. Print the final result.
                */

            StringBuilder newStr= new StringBuilder();

            newStr.Append("Book list");
            Console.WriteLine(newStr);

            newStr.Replace("list", "Library");
            Console.WriteLine(newStr);

            int pages = 464;
            Console.WriteLine(title+" "+pages);
            Console.WriteLine($"{title} {pages}");

            /*  Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
              300, otherwise prints "Short Book".*/
            string message = pages == 464 ? "long book" : "shortbook";
            Console.WriteLine(message);
            /*
             Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
                greater than 300 and isAvailable is true. Use the && operator.
                */
            bool isAvailable = true;

            string message2 = pages >= 300&&isAvailable ?
                "You can borrow this book" :
                "not avilable to borrow it you can read it in librart";

            Console.WriteLine(message2);
            /*
             * Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else
             */
            string ti = "Refactoring";
            string message3 = ti switch
            {
                "Clean Code" => "Nice pick!",
                "Refactoring" => "Never heard of it",
                _ => " other method"
            };
            Console.WriteLine(message3);

            /*
             Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
                to print each book with its position number, like 1. Clean Code.
                */

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
                Console.WriteLine($"{i}- {books[i]}");
                Console.WriteLine($"**********");
            }
            int j = 0;
            do {
                Console.WriteLine(books[j]);
                j++; 
            }
            while (j < books.Length);

            foreach (string i in books) {
                if (i == "The Pragmatic Programmer")
                    continue;
                    
            Console.WriteLine(i);
            }
            Console.WriteLine(" method run ************");
            printFirstBook(books);
        }

       static void printFirstBook(string[] b)
        {
            if (b.Length != 0) { Console.WriteLine(b[0]); }
            else
            {
                Console.WriteLine("array is empty");
            }
        }
    }
}
