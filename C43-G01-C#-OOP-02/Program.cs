using C43_G01_C__OOP_02.Encapsu_ation;
using System.Reflection;
using System.Xml.Linq;

namespace C43_G01_C__OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Struct - Setter Getter

            //Employee emp = new Employee(10, "Gamal", 22, 7000);
            //emp.Id = 1000;
            //Console.WriteLine(emp);
            ////it's wrong before encapsulation to access attribute directly and
            ////if we change in thing in struct any instance deal with this struct will be affected 
            ////we can change it's value 
            ////we can't add validation on it
            //// emp.name ->> it will be error because name is private so we can't deal with attribute directly
            //emp.setName("Gg");
            //Console.WriteLine($"new name: {emp.getName()}");

            #endregion

            #region Property

            #region automatic property

            //emp.Age = 23;
            //Console.WriteLine($"new age: {emp.Age}");

            #endregion

            #region full property

            //Deal with property like attribute but it property it creat a hidden attribute called backfield 
            // it created by compiler in il (assymble code) 
            //Console.WriteLine($"Salary: {emp.Salary}");

            #endregion

            #endregion

            //Ex02
            #region PhoneBook 

            #region Setter-Getter

            //phoneBook note=new phoneBook(3);
            //note.addPerson(0, "Gamal", 123);
            //note.addPerson(1, "ali", 456);
            //note.addPerson(2, "mona", 789);

            //Console.WriteLine(note.GetNumber("Gamal")==-1?"not found":note.GetNumber("Gamal"));

            //note.setNumber(999, "Gamal");

            //Console.WriteLine(note.GetNumber("Gamal"));

            #endregion

            #region Indexer Property

            //phoneBook note1= new phoneBook(3);
            //note1.addPerson(0, "Gamal", 111);
            //note1.addPerson(1, "ahmed", 222);
            //note1.addPerson(2, "monaa", 333);

            //Console.WriteLine(note1["monaa"]);
            //note1["monaa"] = 444;
            //Console.WriteLine(note1["monaa"]);

            ////applying indexer overloadding
            //for(int i = 0; i < note1.size; i++)
            //{
            //    Console.WriteLine(note1[i]);
            //}

            #endregion

            #endregion

            #region Class

            //Car c1 = new Car(10,"BMW",290);
            //Console.WriteLine(c1);

            //Car c2 = new Car(10, "BMW");
            //Console.WriteLine(c2);

            //Car c3 = new Car(10);
            //Console.WriteLine(c3);

            #endregion

            #endregion

            #region Assignment

            #region Part 02

            #region part 02 - Q01

            //Person[] person = new Person[3];
            //person[0] = new Person(23,"Gamal");
            //person[1] = new Person(24,"Ali");
            //person[2] = new Person(25,"Mona");

            //for(int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}

            #endregion

            #region part 02 - Q02

            //Person[] person = new Person[3];
            //for (int i = 0; i < person.Length; i++)
            //{
            //    bool flag;
            //    string name;
            //    int age;
            //    Console.Write($"Enter person [{i}] name: ");
            //    name = Console.ReadLine();
            //    do
            //    {
            //        Console.Write($"Enter person [{i}] age: ");
            //        flag = int.TryParse(Console.ReadLine(), out age);
            //    }while (!flag || age <= 0);
            //    person[i] = new Person(age, name);
            //}

            //int maxAge =-1;
            //int index=-1;
            //for (int i = 0; i < person.Length; i++)
            //{
            //    if(person[i].Age > maxAge)
            //    {
            //        maxAge=person[i].Age;
            //        index = i;
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine($"oldest person: {person[index]}");

            #endregion

            #endregion

            #region Part 03

            //Employee[] emp = new Employee[3];
            //emp[0] = new Employee(10, 5000, "Gamal", new Date(2, 1, 2013), Security.DBA, Gender.m);
            //emp[1] = new Employee(12, 6000, "Mona", new Date(1, 2, 2019), Security.security, Gender.f);
            //emp[2] = new Employee(16, 7000, "Ali", new Date(3, 5, 2014), (Security)7, Gender.m);


            //Console.WriteLine(emp[0]);
            //Console.WriteLine();
            //Console.WriteLine(emp[1]);
            //Console.WriteLine();
            //Console.WriteLine(emp[2]);
            //Console.WriteLine();

            //Console.WriteLine("===================================");
            //Console.WriteLine("After Sorting");
            //Console.WriteLine("===================================");

            //Array.Sort(emp, (x, y) => new DateTime(x.HiringDate.Year, x.HiringDate.Month, x.HiringDate.Day).CompareTo(new DateTime(y.HiringDate.Year, y.HiringDate.Month, y.HiringDate.Day)));

            //foreach (var employee in emp) {
            //    Console.WriteLine($"Id: {employee.GetId()}\nName: {employee.GetName()}\nSalary: {employee.GetSalary():c}\nGender: {employee.gender}\nHiring Date: {employee.HiringDate}\nsecurity Level: {employee.securityLevel}\n");
            //}
            #region if u make user to input data

            //int size;
            //bool flagSize;
            //do
            //{
            //    Console.Write("How many employees u want to store (array size): ");
            //    flagSize = int.TryParse(Console.ReadLine(), out size);
            //} while (!flagSize || size < 0);

            //Employee[] employee = new Employee[size];

            //for (int i = 0; i < size; i++)
            //{
            //    int id;
            //    bool flagId;
            //    do
            //    {
            //        Console.Write($"Enter Employee[{i}] id: ");
            //        flagId = int.TryParse(Console.ReadLine(), out id);
            //    } while (!flagId || id < 0);

            //    double salary;
            //    bool flagSalary;
            //    do
            //    {
            //        Console.Write($"Enter Employee[{i}] Salary: ");
            //        flagSalary = double.TryParse(Console.ReadLine(), out salary);
            //    } while (!flagSalary || salary < 0);

            //    Console.Write($"Enter Employee[{i}] Name: ");
            //    string name = Console.ReadLine();

            //    int day;
            //    bool flagDay;
            //    do
            //    {
            //        Console.Write($"Enter the (Day) of Hiring Date of Employee[{i}]  : ");
            //        flagDay = int.TryParse(Console.ReadLine(), out day);
            //    } while (!flagDay || day < 0 || day > 30);
            //    int month;
            //    bool flagMonth;
            //    do
            //    {
            //        Console.Write($"Enter the (Month) of Hiring Date of Employee[{i}]  : ");
            //        flagMonth = int.TryParse(Console.ReadLine(), out month);
            //    } while (!flagMonth || month < 0 || month > 12);

            //    int year;
            //    bool flagYear;
            //    do
            //    {
            //        Console.Write($"Enter the (Year) of Hiring Date of Employee[{i}]  : ");
            //        flagYear = int.TryParse(Console.ReadLine(), out year);
            //    } while (!flagYear || year < 2000 || year > 2024);

            //    bool flagSecurity;
            //    Security seq;
            //    do
            //    {
            //        Console.Write($"Enter Employee[{i}] Security: ");
            //        flagSecurity = Enum.TryParse(Console.ReadLine(), true, out seq);
            //    } while (!flagSecurity);

            //    bool flagGender;
            //    Gender gen;
            //    do
            //    {
            //        Console.Write($"Enter Employee[{i}] Gender: ");
            //        flagGender = Enum.TryParse(Console.ReadLine(), true, out gen);
            //    } while (!flagGender);

            //    employee[i] = new Employee(id, salary, name, new Date(day, month, year), seq, gen);
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(employee[i]);
            //}

            //Console.WriteLine("===================================");
            //Console.WriteLine("After Sorting");
            //Console.WriteLine("===================================");

            //Array.Sort(employee, (x, y) => new DateTime(x.HiringDate.Year, x.HiringDate.Month, x.HiringDate.Day).CompareTo(new DateTime(y.HiringDate.Year, y.HiringDate.Month, y.HiringDate.Day)));

            //foreach (var emp in employee)
            //{
            //    Console.WriteLine($"Id: {emp.GetId()}\nName: {emp.GetName()}\nSalary: {emp.GetSalary():c}\nGender: {emp.gender}\nHiring Date: {emp.HiringDate}\nsecurity Level: {emp.securityLevel}\n");
            //}


            #endregion



            #endregion

            #endregion


        }
    }
}
