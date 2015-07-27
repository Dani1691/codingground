using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MergeSortAlgorithm
    {
        public static void MergeSort(int[] vector)
        {
            Merge(vector, 0, vector.Length);
        }

        public static void Merge(int[] vector, int abajo, int arriba)
        {
            int N = arriba - abajo;
            if (N <= 1)
                return;
            int media = abajo + N / 2;
            // Recursive sort
            Merge(vector, abajo, media);
            Merge(vector, media, arriba);
            // Combining two vectors
            int[] temp = new int[N];
            int i = abajo, j = media;
            for (int k = 0; k < N; k++)
            {
                if (i == media)
                    temp[k] = vector[j++];
                else if (j == arriba)
                    temp[k] = vector[i++];
                else if (vector[j] < vector[i])
                    temp[k] = vector[j++];
                else
                    temp[k] = vector[i++];
            }
            for (int k = 0; k < N; k++)
                vector[abajo + k] = temp[k];
        }
    }
}