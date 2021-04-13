using System;
using System.Collections;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            
            print();
            ArrayList bookList = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("add {0} booe t the list",i + 1);
                bookList.Add(Book.addBook());
            }

            foreach (var item in bookList)
            {
                Console.WriteLine(item);
            }
            print();
        }

        static void print()
        {
            Console.WriteLine("in library there are {0} books. ",Book.numBooks);
            Console.WriteLine("in library there are {0} books ready for loan.", Book.booksInLib);
        }
    }
}
