using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem casette = new VHS("Digimons", 100);
            IItem software = new DVD("Avengers", DVDType.SOFTWARE, 300);
            IItem movie = new DVD("Avengers", DVDType.MOVIE, 300);
            IItem book = new Book("A brief history of time", 100);

            Cart cart = new Cart();
            cart.AddItem(casette);
            cart.AddItem(software);
            cart.AddItem(movie);
            cart.AddItem(book);

            IVisitor visitor = new RentVisitor();
            cart.setVisitor(visitor);
            Console.WriteLine(cart.Accept());

            
            cart.setVisitor(new BuyVisitor());
            Console.WriteLine(cart.Accept());
        }
    }
}
