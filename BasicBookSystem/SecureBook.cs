using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicBookSystem
{
    internal class SecureBook
    {
        private string _isbn;
        public string Isbn
        {
            get { return _isbn; }
            set{
             if(value.Length == 13)
                {
                    _isbn = value;
                }
            }
        }
        public SecureBook(string isbn)
        {
            this.Isbn = isbn;
        }
       public void DisplayInfo()
        {
            Console.WriteLine($"The ISBN is {Isbn}");
        }
    }
}
