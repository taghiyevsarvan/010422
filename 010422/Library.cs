using _010422.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _010422
{
    internal class Library
    {
        private List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
                throw new NullReferenceException("null ola bilmez");
            else
            {
                _books.Add(book);
                return;
            }
        }

        public List<Book> FindAllBooksByName(string val)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in _books)
            {
                if (val == item.Name)
                    newBooks.Add(item);
            }
            return newBooks;
        }

        public void RemoveAllBookByName(string val)
        {
            foreach (var item in _books)
            {
                if (item.Name == val)
                    _books.Remove(item);
            }

        }


        //public List<Book> SearchBooks(string val)
        //{
        //    //Name, AuthorName, PageCount
        //    List<Book> newBooks = new List<Book>();
        //    foreach (var item in _books)
        //    {
        //        if (val == item.Name)
        //            newBooks.Add(item);
        //        else if (val == item.AuthorName)
        //            newBooks.Add(item);
        //        else if (val == item.PageCount)
        //        (Burda pagecount int dir stringi val axtaris ede bilmirem deye qaldi)
        //            newBooks.Add(item);
        //    }

        //}

        public List<Book> FindAllBooksByPageCountRange(int minVal, int maxVal)
        {
            List<Book> newBook = new List<Book>();
            foreach (var item in _books)
            {
                if (maxVal >= item.No && minVal <= item.No)
                    newBook.Add(item);
            }
            return newBook;
        }

        public void RemoveByCode(int? no)
        {
            if (no == null)
                throw new NullReferenceException("id null ola bilmez");
            
            foreach (var item in _books)
            {

                if (no == item.No)
                    _books.Remove(item);
                return;
            }

            throw new NotFoundException($"bu {no} idli kitab tapilmadi");

        }
    }
}
