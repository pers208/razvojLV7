using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearchStrategy searchStrategy = new LinearSearch();
            double[] array = { 1.74, 148, 7, 16, 4, -2, -3, 500, 9, 11 };
            NumberSequence numberSequence = new NumberSequence(array);
            numberSequence.SetSearchStrategy(searchStrategy);
            Console.WriteLine(numberSequence.Search(-2));
            Console.WriteLine(numberSequence.Search(-277));
        }
    }
}
