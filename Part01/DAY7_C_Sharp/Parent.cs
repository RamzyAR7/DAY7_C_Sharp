using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public virtual int product()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"X : {X}, Y : {Y}";
        }
    }
    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
        //public new int product()
        //{
        //    return X * Y * Z;
        //}
        public override int product()
        {
            return base.product() * Z;
        }
        public override string ToString()
        {
            return base.ToString() + $", Z : {Z}";
        }
    }
}