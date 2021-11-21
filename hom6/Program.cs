using Information;
using System;

namespace hom6
{
   

    public class Program
    {

        static void Main(string[] args)
        {
           
            Library l = new Library();


            Console.Write("введите индекс книги для поиска от 1 до 7 (в библиотеке 7 книг):\t");

            int index = Convert.ToInt32(Console.ReadLine());

            if (index > 0 && index <= 7)
            {
                Book book = l[index - 1];
                Console.WriteLine($"{book.Name}  has {book.Pages} and placed in {book.LibraryName}");

            }


            else
            {
                Console.WriteLine("not correct index");

            }

            Console.Write("введите название  книги для поиска от book1 до book7 (в библиотеке 7 книг):\t");

            string nameofbook = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < l.Count; i++)
            {
                if (nameofbook.Equals(l[i].Name))   //  сравнение срок
                {
                    found = true;
                    Console.WriteLine($"{l[i].Name}  has {l[i].Pages} and placed in {l[i].LibraryName}");
                    break;
                }

            }

            if (found == false)   // compare
                Console.WriteLine($"no book in library");


            Book bigbool = l.BigBook();
            Console.WriteLine($"The biggest boo is  {bigbool.Name}  has {bigbool.Pages} and placed in {bigbool.LibraryName}");






        }

    }



}






