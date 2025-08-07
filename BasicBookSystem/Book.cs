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
        private int _pagesRead;
        public int PagesRead
        {
            get { return _pagesRead; }
            private set
            {
                _pagesRead = value;
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
        public void Read(int pages)
        {
            if(pages <= 0)
            {
                Console.WriteLine("You have entered an invalid number");
            } else if (PagesRead + pages > NumberOfPages){
                Console.WriteLine("You can't read beyond the end of the book");
            }
            else
            {
                PagesRead += pages;
                Console.WriteLine($"You have read {PagesRead} of {NumberOfPages}");
            }
        }
    }

}

