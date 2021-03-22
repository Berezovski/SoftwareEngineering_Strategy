using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Интерфейс основного класса сортировок
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISorts<T>
    {
        public void ChangeSortOption(SortOption sortOption);
        public void ChangeComparer(IComparer<T> comparer);
        public T[] AscendingSort(T[] array);
        public T[] DescendingSort(T[] array);
    }
}
