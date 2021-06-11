using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class Vehicle
    {
        public int no_of_wheels = 1;

        public virtual void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }


    }
    class Car : Vehicle
    {
        public new int no_of_wheels=4;
            public override void honk()
        {
            Console.WriteLine("BEEp BEEP....");
        }
    }
}
