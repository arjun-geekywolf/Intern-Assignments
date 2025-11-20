using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{

    public class Books
    {
        public string Title;
        public string Author;
        public int Price;

        public Books(string title, string author, int price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public void BookDetails()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPrice: {Price}\n");
        }
    }




}
