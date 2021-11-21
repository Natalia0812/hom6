using System;
using System.Linq;



namespace Information
{
    public class Library
    {
        private Book[] books = new Book[] { };

        public int Count { get; set; }

        public Book this[int index]
        {

            get { return books[index]; }
            set { books[index] = value; }

        }

         public Book this[string name] => books.FirstOrDefault(b => b.Name.Equals(name));

       
        // наша библиотека книшг содержит 7 книг, предположим, которые хранятся в 3-х библиотеках

        public Library()
        {
            books = new Book[]
            {
            new Book { Name = "book1", Pages = 53, LibraryName = "Lib1" },

            new Book { Name = "book2", Pages = 213, LibraryName = "Lib1" },

             new Book { Name = "book3", Pages = 43, LibraryName = "Lib1" },
             new Book { Name = "book4", Pages = 65, LibraryName = "Lib2" },
           new Book { Name = "book5", Pages = 66, LibraryName = "Lib2" },
             new Book { Name = "book6", Pages = 6, LibraryName = "Lib3" },
            new Book { Name = "book7", Pages = 76, LibraryName = "Lib3" }
                 };

            Count = 7;
        }

    }





}
