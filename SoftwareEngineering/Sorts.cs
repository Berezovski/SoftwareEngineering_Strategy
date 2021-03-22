using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Основной класс всех сортировок, в котором реализован паттерн "стратегия"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Sorts<T> : ISorts<T>
    {
        private ISortStrategy<T> _sortStrategy;
        private IComparer<T> _comparer;

        public Sorts(IComparer<T> comparer, SortOption sortStrategy)
        {
            _comparer = comparer;
            ChangeSortOption(sortStrategy);
        }

        public Sorts(IComparer<T> comparer) : this (comparer, SortOption.Bubble)
        { }

        public void ChangeSortOption(SortOption sortOption)
        {
            switch (sortOption)
            {
                case SortOption.Bubble:
                    _sortStrategy = new BubbleSort<T>();
                    break;
                case SortOption.Insertion:
                    _sortStrategy = new InsertionSort<T>();
                    break;
                case SortOption.Selection:
                    _sortStrategy = new SelectionSort<T>();
                    break;
                case SortOption.Heap:
                    _sortStrategy = new HeapSort<T>();
                    break;
                case SortOption.Quick:
                    _sortStrategy = new QuickSort<T>();
                    break;
                default:
                    _sortStrategy = new BubbleSort<T>();
                    break;
            }
        }

        public void ChangeComparer(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public T[] AscendingSort(T[] array)
        {
            T[] cloneArr = (T[])array.Clone();
            _sortStrategy.AscendingSort(cloneArr, _comparer);

            return cloneArr;
        }

        public T[] DescendingSort(T[] array)
        {
            T[] cloneArr = (T[])array.Clone();
            _sortStrategy.DescendingSort(cloneArr, _comparer);

            return cloneArr;
        }

    }
}
