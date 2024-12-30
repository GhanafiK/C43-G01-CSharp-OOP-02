using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02.Encapsu_ation
{
    internal struct phoneBook
    {
        #region attributes
        string[] names;
        int[] numbers;
        int size;
        #endregion

        #region Constructor
        public phoneBook(int size)
        {
            names = new string[size];
            numbers = new int[size];
            this.size = size;
        }
        #endregion

        #region Methods
        public void addPerson(int position, string name, int num)
        {
            if (names != null && numbers != null && position < size)
            {
                names[position] = name;
                numbers[position] = num;
            }
        }

        public int GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i]; ;
                }
            }
            return -1;
        }

        public void setNumber(int num, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = num;
                    break;
                }
            }
        } 
        #endregion
    }
}
