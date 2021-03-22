using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Интерфейс сортировок (используется для реализации паттерна стратегия)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISortStrategy<T>
    {
        void AscendingSort(T[] array, IComparer<T> comparer);
        void DescendingSort(T[] array, IComparer<T> comparer);
    }
}
