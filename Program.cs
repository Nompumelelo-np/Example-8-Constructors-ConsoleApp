using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8_Constructors_ConsoleApp
{
    class Book
    { 
    public string title;
    public string author;
    public int pages;


        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
    
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Talkein", 900);

            Console.WriteLine("The title of book1 is " + book1.title);
            Console.WriteLine("The number of pages of book2 is " + book2.pages);

            Console.ReadLine();
        }
    }
}
