using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Сортировка выбором
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SelectionSort<T> : ISortStrategy<T>
    {
        public void AscendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            int tmpIndex;
            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                tmpIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (comparer.Compare(tmp, array[j]) == 1)
                    {
                        tmp = array[j];
                        tmpIndex = j;
                    }
                }

                array[tmpIndex] = array[i];
                array[i] = tmp;
            }
        }

        public void DescendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            int tmpIndex;
            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                tmpIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (comparer.Compare(tmp, array[j]) == -1)
                    {
                        tmp = array[j];
                        tmpIndex = j;
                    }
                }

                array[tmpIndex] = array[i];
                array[i] = tmp;
            }
        }
    }
}
