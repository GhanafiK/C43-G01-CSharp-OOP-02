using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02
{
    [Flags]
    public enum Security:byte
    {
        guest=1, secretary=2, DBA=4, security=8
    }

    public enum Gender
    {
        m,f
    }

    internal class Employee
    {

        #region attributs
        public int Id;
        public double Salary;
        public string Name;
        public Date HiringDate;
        #endregion

        #region properties
        public Security securityLevel { get; set; }
        public Gender gender { get; set; } 
        #endregion

        public Employee(int id, double salary,string name, Date hiringDate, Security securityLevel, Gender gender)
        {
            Id = id;
            Salary = salary;
            Name = name;
            HiringDate = hiringDate;
            this.securityLevel = securityLevel;
            this.gender = gender;
        }

        #region Setter - Getter
        public void setId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetSalary(double salary)
        {
            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetDate(Date hiringDate)
        {
            HiringDate = hiringDate;
        }

        public Date GetDate()
        {
            return HiringDate;
        }

        #endregion


        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSalary: {Salary:c}\nGender: {gender}\nHiring Date: {HiringDate}\nsecurity Level: {securityLevel}\n";
        }
    }
}
