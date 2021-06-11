using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    class TypeCastExample
    {
        
        double double_num = 5.25;
        bool boolvar = true;

        public void cast()
        { int y = (int)double_num;
            Console.WriteLine("value of y is" + y);
            Console.WriteLine("Integer to String Conversion" + y.ToString());
                Console.WriteLine("Integer to String Conversion by onother method" + Convert.ToString(y));

        }






    }
}
