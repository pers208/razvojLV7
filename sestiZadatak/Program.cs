using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            VHS casette = new VHS("Digimons", 100);
            DVD software = new DVD("Avengers", DVDType.SOFTWARE, 300);
            DVD movie = new DVD("Avengers", DVDType.MOVIE, 300);
            Book book = new Book("A brief history of time", 100);
            IVisitor visitor = new RentVisitor();
            Console.WriteLine(visitor.Visit(casette));
            Console.WriteLine(visitor.Visit(software));
            Console.WriteLine(visitor.Visit(movie));
            Console.WriteLine(visitor.Visit(book));
        }
    }
}
