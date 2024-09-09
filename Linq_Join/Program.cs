using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var authorList = new List<Author>()
            {
                new Author(1,"George Orwell"),
                new Author(2,"J.K. Rowling"),
                new Author(3,"J.R.R. Tolkien"),
                new Author(4,"Jane Austen"),
                new Author(5,"Ernest Hemingway"),
            };
            var bookList = new List<Book>()
            {
                new Book(1,"1984",1),
                new Book(2,"Harry Potter and the Philosopher's Stone",2),
                new Book(3,"The Lord of the Rings",3),
                new Book(4,"Pride and Prejudice",4),
                new Book(5,"The Old Man and the Sea",5)
            };

            var result = from author in authorList
                         join book in bookList on author.AuthorId equals book.AuthorId
                         select new { book.BookId, book.Title, author.Name };

            foreach (var author in result)
            {
                Console.WriteLine($"{author.BookId} - Kitap Adı : {author.Title} - Yazarın Adı : {author.Name}\n");
            }
            
            Console.ReadLine();


        }
    }
}
