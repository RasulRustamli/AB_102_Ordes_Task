using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    internal class Library
    {
       
       Book[] Books =new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;

        }
        public Book GetBook(string Code)
        {
          foreach (Book book in Books)
            {
                if (book.Code.ToLower() == Code.ToLower())
                {
                    return book;
                }
            }
          return null;
        }
        public int RemoveAllNameBooks(string name)
        {
            int count = 0;
            Book[] RemoveBooks= new Book[0];
            for (int i = 0; i <Books.Length ; i++)
            {
                if(Books[i].Name.ToLower() != name.ToLower())
                {
                    Array.Resize(ref RemoveBooks, RemoveBooks.Length+1);
                    RemoveBooks[RemoveBooks.Length-1] = Books[i];
                }
                else
                {
                    count++;
                }
            }
            Books = RemoveBooks;
            return count;
        }

    }
}
