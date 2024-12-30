using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02.Encapsu_ation
{
    internal struct Employee
    {
        #region Property
        public int Id;
        string Name;//use setter and getter with it
        public int Age { get; set; }//use automatic property
        decimal salary; // use full property 
        #endregion

        #region Constructor
        public Employee(int id, string name, int age, decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary; //to check if value in constructor > 5000 set it 5000 otherwise set it with it's value
        }
        #endregion

        #region Methods
        public void setName(string name)
        {
            Name = name.Length > 5 ? name.Substring(0, 5) : name;

        }
        public string getName() { return Name; }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                salary = value > 5000 ? 5000 : value;
            }
        }

        //public decimal deduction; // deriven attribute 
        public decimal Deduction
        {
            get { return salary - salary * .25m; }
        }

        public override string ToString()
        {
            return $"id: {Id} - name: {Name} - age: {Age} - salary:{salary}";
        } 
        #endregion
    }
}
