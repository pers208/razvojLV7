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
            ISearchStrategy linearSearch = new LinearSearch();
            Random generator = new Random();
            double[] array = new double[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = generator.Next(1, 10);
            }
            NumberSequence numberSequence = new NumberSequence(array);
            numberSequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(numberSequence.Search(1));
            Console.WriteLine(numberSequence.Search(-277));
        }
    }
}
