using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    internal interface IMovable
    {
        void Move();
    }

    class Car2 : IMovable
    {
        public string Model { get; set; }

        public Car2(string _Model)
        {
            Model = _Model;   
        }

        public void Move()
        {
            Console.WriteLine($"The car {Model} is moving.");
        }
    }
}
