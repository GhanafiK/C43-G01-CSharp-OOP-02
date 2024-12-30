using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02
{
    internal class Person
    {

        #region Attributes
        public int Age { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Person(int age,string name)
        {
            Age = age;
            Name = name;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Name: {Name} ::: Age: {Age}";
        }


        #endregion
    }
}
