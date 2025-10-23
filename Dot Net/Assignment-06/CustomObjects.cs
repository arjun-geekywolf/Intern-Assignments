using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{

    public class Books
    {
        public string title;
        public string author;
        public int price;

        public Books(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void BookDetails()
        {
            Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}\n");
        }
    }




}
