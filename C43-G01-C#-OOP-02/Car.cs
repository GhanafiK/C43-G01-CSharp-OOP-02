using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public Car(int Id,string Model, double speed)
        {
            this.Id = Id;
            this.Model = Model;
            this.Speed = speed;
            Console.WriteLine("Ctor1");
        }

        // override constructors
        #region Chaining constructor

        public Car(int Id, string Model):this(Id,Model,290) {
            Console.WriteLine("Ctor2");
        }

        public Car(int Id) : this(Id, "Audi")
        {
            Console.WriteLine("Ctor3");
        }

        #endregion

        public override string ToString()
        {
            return $"Id:{Id} ::: Model:{Model} ::: Speed:{Speed}";
        }
    }
}
