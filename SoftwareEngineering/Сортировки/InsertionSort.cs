using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Сортировка вставками
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class InsertionSort<T> : ISortStrategy<T>
    {
        public void AscendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            for (int i = 1; i < array.Length; i++)
            {
                tmp = array[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (comparer.Compare(array[j], tmp) == 1)
                    {
                         array[j+1] = array[j];
                    }
                    else
                    {
                        array[j+1] = tmp;
                        break;
                    }

                    if (j == 0)
                    {
                        array[j] = tmp;
                    }
                }

            }
        }

        public void DescendingSort(T[] array, IComparer<T> comparer)
        {
            T tmp;
            for (int i = 1; i < array.Length; i++)
            {
                tmp = array[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (comparer.Compare(array[j], tmp) == -1)
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        array[j + 1] = tmp;
                        break;
                    }

                    if (j == 0)
                    {
                        array[j] = tmp;
                    }
                }

            }
        }
    }
}
