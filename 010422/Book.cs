using System;
using System.Collections.Generic;
using System.Text;

namespace _010422
{
    internal class Book
    {
        public Book()
        {
            _no++;
            No = _no;
        }
        private static int _no;
        public int No { get; }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"No: {No} - Name {Name} - AuthorName {AuthorName} - PageCount {PageCount}");
        }
    }
}
