using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    internal class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public Car(int _Id):this(_Id, null, 0.0)
        {
            
        }
        public Car(int _Id, string _Brand):this(_Id, _Brand, 0.0)
        {
            
        }
        public Car(int _Id, string _Brand, double _Price)
        {
            Id = _Id;
            Brand = _Brand;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Brand : {Brand}, Price : {Price}";
        }
    }
}
