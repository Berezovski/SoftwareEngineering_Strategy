using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Быстрая сортировка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QuickSort<T> : ISortStrategy<T>
    {
        public void AscendingSort(T[] array, IComparer<T> comparer)
        {
            AscendingQuickSortRecursive(array, comparer, 0, array.Length - 1);
        }

        public void DescendingSort(T[] array, IComparer<T> comparer)
        {
            DescendingQuickSortRecursive(array, comparer, 0, array.Length - 1);
        }

        private int DescendingPermutation(T[] array, IComparer<T> comparer, int startingCutArrayIndex, int endingCutArrayIndex)
        {
            int marker = startingCutArrayIndex;
            for (int i = startingCutArrayIndex; i <= endingCutArrayIndex; i++)
            {
                if ((comparer.Compare(array[i], array[endingCutArrayIndex]) == 1) 
                    || (comparer.Compare(array[i], array[endingCutArrayIndex]) == 0))
                {
                    T tmp = array[marker];
                    array[marker] = array[i];
                    array[i] = tmp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        // возвращает индекс центрального элемента
        private int AscendingPermutation(T[] array, IComparer<T> comparer, int startingCutArrayIndex, int endingCutArrayIndex)
        {
            int marker = startingCutArrayIndex;
            for (int i = startingCutArrayIndex; i <= endingCutArrayIndex; i++)
            {
                // если элемент слева больше жлемента справа, то меняем местами и переписываем маркер центрального элемента
                if ((comparer.Compare(array[i], array[endingCutArrayIndex]) == -1)
                    || (comparer.Compare(array[i], array[endingCutArrayIndex]) == 0))
                {
                    T tmp = array[marker];
                    array[marker] = array[i];
                    array[i] = tmp;

                    marker += 1;
                }
            }
            return marker - 1;
        }

        // Основная Рекурсивная функция
        private void AscendingQuickSortRecursive(T[] array, IComparer<T> comparer, int startingCutArrayIndex, int endingCutArrayIndex)
        {
            if (startingCutArrayIndex >= endingCutArrayIndex)
            {
                return;
            }

            int middleValue = AscendingPermutation(array, comparer, startingCutArrayIndex, endingCutArrayIndex);
            AscendingQuickSortRecursive(array, comparer, startingCutArrayIndex, middleValue - 1);
            AscendingQuickSortRecursive(array, comparer, middleValue + 1, endingCutArrayIndex);
        }

        private void DescendingQuickSortRecursive(T[] array, IComparer<T> comparer, int startingCutArrayIndex, int endingCutArrayIndex)
        {
            if (startingCutArrayIndex >= endingCutArrayIndex)
            {
                return;
            }

            int middleValue = DescendingPermutation(array, comparer, startingCutArrayIndex, endingCutArrayIndex);
            DescendingQuickSortRecursive(array, comparer, startingCutArrayIndex, middleValue - 1);
            DescendingQuickSortRecursive(array, comparer, middleValue + 1, endingCutArrayIndex);
        }
    }
}
