using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            CombSort combSort = new CombSort();
            SequentialSort sequentialSort = new SequentialSort();
            Random generator = new Random();
            double[] array = new double[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = generator.Next(1, 10);
            }
            NumberSequence numberSequence = new NumberSequence(array);
            numberSequence.SetSortStrategy(bubbleSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());

            for (int i = 0; i < 10; i++)
            {
                numberSequence.InsertAt(i, array[i]);
            }
            numberSequence.SetSortStrategy(combSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());

            for (int i = 0; i < 10; i++)
            {
                numberSequence.InsertAt(i, array[i]);
            }
            numberSequence.SetSortStrategy(sequentialSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());
        }
    }
}
