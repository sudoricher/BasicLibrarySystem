using System;

namespace BasicBookSystem
{
    public class Book
    {
        private string _title;
        public string Title {
            get { return _title; }
            set
            {
                _title = value;
            }
        }
        public string Author { get; set; }

        private int _numberOfPages;
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set
            {
                if (value > 0) _numberOfPages = value;
            }
        }
        public Book(string title, string author, int numberOfPages)
        {
            this.Title = title;
            this.Author = author;
            this.NumberOfPages = numberOfPages;
        }
        public void DescribeBook()
        {
            string summary = $"Title: {Title} Author: {Author} Pages:{NumberOfPages}";
            Console.WriteLine(summary);
        }

    }
}
