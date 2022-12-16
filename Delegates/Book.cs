using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Book
    {
        public string Author { get; set; }
        public int Count { get; set; }

        public void ShowBookInfo(Predicate<string>author)
        {
            Book book1 = new Book();
            book1.Author = "Nizami";
            book1.Count = 5;
            Book book2 = new Book();
            book2.Author = "Shahriyar";
            book2.Count = 5;
            Book book3 = new Book();
            book3.Author = "Nizami";
            book3.Count = 5;

            List<Book> list = new List<Book>();
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);

            foreach (var item in list)
            {
                if (author(item.Author))
                {
                    Console.WriteLine($"{item.Count}");
                }
            }
            
        }
    }
}
