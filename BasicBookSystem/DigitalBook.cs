using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicBookSystem
{
    class DigitalBook : Book
    {
        public int FileSize { get; set; }
        public DigitalBook(string title, string author, int numberOfPages, int fileSize) : base(title, author, numberOfPages)
        {
        this.FileSize = fileSize;
        }
        public override void DescribeBook()
        {
            string summary = $"Title: {Title} Author: {Author} Pages:{NumberOfPages} Filesize: {FileSize}MB";
            Console.WriteLine(summary);
        }
    }
}
