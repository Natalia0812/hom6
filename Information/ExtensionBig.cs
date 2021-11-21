using System;
using System.Collections.Generic;
using System.Text;

namespace Information
{
    public static class Biggest
    {
        public static Book BigBook(this Library library)
        {
            Book book = library[0];
            for (int i = 1; i < library.Count; i++)
            {
                if (library[i].Pages > book.Pages)
                {
                    book = library[i];


                }
            }

            return book;

        }



















    }
}