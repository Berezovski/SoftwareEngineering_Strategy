using System;
using System.Collections.Generic;

namespace SoftwareEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> dic = new List<People>();

            
            // Создадим множество автомобилей
            dic.Add(new People(300000, 25, 171, "Леонид"));
            dic.Add(new People(220000, 20, 172, "Naruto"));
            dic.Add(new People( 260000, 25, 177, "Аниме"));
            dic.Add(new People( 400000, 27, 171, "Zeus"));
            dic.Add(new People( 420000, 23, 175, "Люда"));

            People[] plArr= dic.ToArray();
            Sorts<People> bsort = new Sorts<People>(new HeightComparer(), SortOption.Bubble);
            plArr = bsort.AscendingSort(plArr);
            

            foreach (People pl in plArr)
            {
                Console.WriteLine(pl.Height + " " + pl.Name);
            }



        }
    }
}
