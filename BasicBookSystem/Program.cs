using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BasicBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book theAlchemist = new Book("The Alchemist", "Paulo Coelho", 208);
            theAlchemist.DescribeBook();
            Book atomicHabits = new Book("Atomic Habits", "James Clear", 320);
            atomicHabits.DescribeBook();
            Book myBook = new Book("Clean Code", "Robert C. Martin", 464);
            myBook.DescribeBook();
            myBook.CheckOut();
            myBook.CheckOut(); // Try again
            myBook.Read(50);
            myBook.Read(500); // Too much
            myBook.Read(-10); // Invalid
            myBook.Read(414); // Should reach 464
            myBook.ReturnBook();
            myBook.ReturnBook(); // Try again
        }
    }
}
