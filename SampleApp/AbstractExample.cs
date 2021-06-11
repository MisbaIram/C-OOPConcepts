using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
   abstract class Button
    {
        const int num = 100;

        public abstract void onclick();
        public void squareroot()
        {
            Console.WriteLine("Square root of:{0} is {1}", num, (num * num));
        }
    }
    class   Submit: Button
    {

        public String Button_shape { get; set; }
        public override  void onclick()
        {
            Console.WriteLine("Move to next page");
        }

    }
}
