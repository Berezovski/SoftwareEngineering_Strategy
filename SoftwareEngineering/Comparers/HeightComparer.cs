using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Класс, реализующий интерфейс сравнения (класса People по полю Height)
    /// </summary>
    class HeightComparer : IComparer<People>
    {
        public int Compare([DisallowNull] People x, [DisallowNull] People y)
        {
            if (x.Height < y.Height)
            {
                return -1;
            }
            else if (x.Height > y.Height)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
