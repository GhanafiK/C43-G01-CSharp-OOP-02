using C43_G01_C__OOP_02.Encapsu_ation;

namespace C43_G01_C__OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Struct - Setter Getter

            Employee emp = new Employee(10, "Gamal", 22, 7000);
            emp.Id = 1000;
            Console.WriteLine(emp);
            //it's wrong before encapsulation to access attribute directly and
            //if we change in thing in struct any instance deal with this struct will be affected 
            //we can change it's value 
            //we can't add validation on it
            // emp.name ->> it will be error because name is private so we can't deal with attribute directly
            emp.setName("Gg");
            Console.WriteLine($"new name: {emp.getName()}");

            #endregion

            #region Property

            #region automatic property
            emp.Age = 23;
            Console.WriteLine($"new age: {emp.Age}");
            #endregion

            #region full property
            //Deal with property like attribute but it property it creat a hidden attribute called backfield 
            // it created by compiler in il (assymble code) 
            Console.WriteLine($"Salary: {emp.Salary}");    
            #endregion

            #endregion

            #endregion


        }
    }
}
