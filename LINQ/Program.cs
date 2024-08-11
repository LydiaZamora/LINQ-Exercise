using System.Linq;
using System.Collections.Generic;
namespace LINQ 
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favBooks = new List<string>()
            { "slaughterhouse five", "harry potter and prisoner of azkaban", "narrow road to the deep north", "catch 22", "atlas shrugged"};

            var booksByLength = favBooks.OrderBy(book => book.Length);

            foreach(var item in booksByLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}
