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
        }
    }
}
