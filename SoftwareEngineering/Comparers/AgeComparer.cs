using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Класс, реализующий интерфейс сравнения (класса People по полю Age)
    /// </summary>
    class AgeComparer : IComparer<People>
    {
        public int Compare([DisallowNull] People x, [DisallowNull] People y)
        {
            if (x.Age < y.Age)
            {
                return -1;
            }
            else if (x.Age > y.Age)
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
