using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BubbleSortAlgorithm
    {
        /*Bubble Sort By Daniel */
        public static void BubbleSort(int[] vector)
        {
            int i, j;
            int aux;

            for (i = vector.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {

                        aux = vector[j + 1];

                        vector[j + 1] = vector[j];

                        vector[j] = aux;
                    }
                }
            }

        }
    }
}
