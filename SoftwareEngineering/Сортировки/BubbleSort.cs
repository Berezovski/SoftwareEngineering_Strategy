using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Пузырьковая сортировка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BubbleSort<T> : ISortStrategy<T>
    {
        public void AscendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) == 1)
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
        }

        public void DescendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) == -1)
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
        }
    }
}
