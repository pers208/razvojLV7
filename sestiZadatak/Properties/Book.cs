using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestiZadatak
{
    class Book:IItem
    {
        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public double Price { get; private set; }
        public override string ToString()
        {
            return "Book: " + this.Title +
           Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor) { return visitor.Visit(this); }
    }
}
