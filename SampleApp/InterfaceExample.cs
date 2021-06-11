using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
     interface Iinterfacefly
    {
        void fly();
    }
    class Bird: Iinterfacefly
    {
       public void fly()
        {
            Console.WriteLine(" I fly very high");
        }

      
    }
    class Aeroplane:Iinterfacefly
    {
       public void fly()
        {
            Console.WriteLine(" I fly very high high");
        }

    }
}
