using System;

namespace ThirtyDaysOfCode.Days
{
    abstract class Book
    {
        protected string title;
        protected string author;
        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book
    {
        private int price { get; set; }
        public MyBook(string title,
                      string author,
                      int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }
    public class Day13
    {
        public static void Execute()
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

    }
    
    
}