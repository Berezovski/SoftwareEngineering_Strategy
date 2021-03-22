using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Пирамидальная сортировка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class HeapSort<T> : ISortStrategy<T>
    {
        public void AscendingSort(T[] array, IComparer<T> comparer)
        {
            // поверяем начиная с последнего левого элемента, который является родительским
            for (int i = array.Length/2 - 1; i >= 0; i--)
            {
                AscendingPyramidWalkWay(array, array.Length, i, comparer);
            }

            // чтобы не тратить память, перегруппируем этот же массив
            for (int i = array.Length - 1; i >= 0; i--)
            {
                T tmp = array[0];
                array[0] = array[i];
                array[i] = tmp;

                AscendingPyramidWalkWay(array, i, 0, comparer);
            }
        }

        // функция для построения пирамиды (дочерних элементов)
        private void AscendingPyramidWalkWay(T[] array, int arrayLength, int elementIndex, IComparer<T> comparer)
        {
            int biggestElementIndex = elementIndex;
            int leftChildElementIndex = 2 * elementIndex + 1;
            int rightChildElementIndex = 2 * elementIndex + 2;

            // если идёт проверка элемента, который находится вне указанного размера, то пропускаем эту проверку
            // если находим в узле в левом дочернем элементе значение, которое больше родительского, то он теперь будет родительским (потом)
            if ((leftChildElementIndex < arrayLength) &&
                (comparer.Compare(array[biggestElementIndex], array[leftChildElementIndex]) == -1))
            {
                biggestElementIndex = leftChildElementIndex;
            }

            // если идёт проверка элемента, который находится вне указанного размера, то пропускаем эту проверку
            // если находим в узле в правом дочернем элементе значение, которое больше родительского, то он теперь будет родительским (потом)
            if ((rightChildElementIndex < arrayLength) &&
                (comparer.Compare(array[biggestElementIndex], array[rightChildElementIndex]) == -1))
            {
                biggestElementIndex = rightChildElementIndex;
            }

            // если нашли элемент, который больше родительского, то свапаем их, 
            // проверяем (те же действия), для нового нынче дочернего элемента
            if (biggestElementIndex != elementIndex)
            {
                T tmp = array[biggestElementIndex];
                array[biggestElementIndex] = array[elementIndex];
                array[elementIndex] = tmp;

                AscendingPyramidWalkWay(array, arrayLength, biggestElementIndex, comparer);
            }

        }

        private void DescendingPyramidWalkWay(T[] array, int arrayLength, int elementIndex, IComparer<T> comparer)
        {
            int biggestElementIndex = elementIndex;
            int leftChildElementIndex = 2 * elementIndex + 1;
            int rightChildElementIndex = 2 * elementIndex + 2;

            if ((leftChildElementIndex < arrayLength) &&
                (comparer.Compare(array[biggestElementIndex], array[leftChildElementIndex]) == 1))
            {
                biggestElementIndex = leftChildElementIndex;
            }

            if ((rightChildElementIndex < arrayLength) &&
                (comparer.Compare(array[biggestElementIndex], array[rightChildElementIndex]) == 1))
            {
                biggestElementIndex = rightChildElementIndex;
            }

            if (biggestElementIndex != elementIndex)
            {
                T tmp = array[biggestElementIndex];
                array[biggestElementIndex] = array[elementIndex];
                array[elementIndex] = tmp;

                DescendingPyramidWalkWay(array, arrayLength, biggestElementIndex, comparer);
            }

        }

        public void DescendingSort(T[] array, IComparer<T> comparer)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                DescendingPyramidWalkWay(array, array.Length, i, comparer);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                T tmp = array[0];
                array[0] = array[i];
                array[i] = tmp;

                DescendingPyramidWalkWay(array, i, 0, comparer);
            }
        }
    }
}
