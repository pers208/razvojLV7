using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    class LinearSearch : ISearchStrategy
    {
        public bool Search(double[] array,double x)
        {
            for(int index = 0; index < array.Length; index++)
            {
                if (array[index] == x) return true;
            }
            return false;
        }
    }
}
