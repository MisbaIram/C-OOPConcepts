//using System;
using System;

namespace SampleApp
{
    public class MyClass
    {
        int a;
        private string color;
        private int price;

        public int A { get; set; }

        public string Color { get; set; }


        public int Price { get; set; }

       public MyClass(int A,string b,int c){
             this.a=A ;
            color = b;
            price = c;

            }
        public int myfunc()
        {
            Console.WriteLine("Displaying color inside my function" +this.color);
            return a * a;
        }
    }

    public class Person
    {
        public int age { get; set; }
    }
}
