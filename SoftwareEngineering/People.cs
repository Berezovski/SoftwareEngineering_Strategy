using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoftwareEngineering
{
    /// <summary>
    /// Класс-пример, объекты класса будут использоваться в массиве
    /// </summary>
    class People : ICloneable
    {
        public int Power{get;set;}
        public int Age { get; set; }
        public int Height { get; set;}
        public string Name { get; set;}

        public People() : this(10,20,175, "Александр")
        {  }

        public People(int pow, int age, int hei, string name)
        {
            Power = pow;
            Age = age;
            Height = hei;
            Name = name;
        }

        public object Clone()
        {
            return new People(Power,Age,Height,Name);
        }
    }
}
