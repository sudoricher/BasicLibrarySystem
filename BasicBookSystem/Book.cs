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
        private bool _isCheckedOut;
        public bool IsCheckedOut
        {
            get { return _isCheckedOut; }
            set
            {
                _isCheckedOut = value;
            }
        }

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

        public void CheckOut()
        {
            if (IsCheckedOut == false)
            {
                IsCheckedOut = true;
                Console.WriteLine("Book is checked out successfully");
            }
            else
            {
                Console.WriteLine("Book is already checked out.");
            }
        }
        public void ReturnBook()
        {
            if (IsCheckedOut)
            {
                IsCheckedOut = false;
                Console.WriteLine("Book is returned");
            }
            else
            {
                Console.WriteLine("Book was not checked out");
            }
        }
    }

}

