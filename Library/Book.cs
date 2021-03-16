using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public static int numBooks;
        public static int booksInLib;
        int bookNumber;
        string booksName;
        string author;
        int pages;
        private bool inLibrary;

        public bool InLibrary
        {
            get { return inLibrary; }
            set
            {
                booksInLib = value ?
                    inLibrary == false? booksInLib + 1: booksInLib + 0 :
                    inLibrary == true ? booksInLib - 1  :booksInLib + 0;
                inLibrary = value;     
            }
        }
        public Book(string booksName, string author)
        {
            this.booksName = booksName;
            this.author = author;
            pages = new Random().Next(215, 499);
        }

        public override string ToString()
        {
            return string.Format(" book number: {4}\n" +
                " books name: {0}\n" +
                " aother: {1}\n" +
                " pages in book: {2}\n" +
                " read for loan: {3}\n"
                , booksName, author, pages, InLibrary , bookNumber);
        }
         public static Book addBook()
        {
            numBooks++;

            Console.WriteLine("enret the name of tke book");
            string name = Console.ReadLine();
            Console.WriteLine("enret the name of tke book");
            string auther = Console.ReadLine();
            Book temp = new Book(name, auther);
            //temp.InLibrary = true;
            temp.InLibrary = new Random().Next(0, 2) == 1;

            
            //temp.InLibrary = booksInLib % 3 == 0 ? false : true;

            temp.bookNumber = numBooks;
            return temp;
            
        }
    }
}
