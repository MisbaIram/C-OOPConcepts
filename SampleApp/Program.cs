using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Using  Properties.........");
            //var obj = new MyClass(20,"red",40);
            var obj1 = new MyClass(20, "red", 40) { A = 12 ,Color = "yellow", Price = 40 };
           // var obj2 = new MyClass { A = 25, Color = "yellow", Price = 40 };
            Person p = new Person();
            p.age = 2;

            var p1= new Person {age = 2 };


          //  obj.A = 12;
           // obj.Color = "red";
            //obj.A = 20;
            Console.WriteLine(obj1.myfunc());
            Console.WriteLine("The color of shoe is "+obj1.Color);
            Console.WriteLine("The price of shoe is " + obj1.Price);
            Console.WriteLine($"{obj1.A}");

            /*Method Ovveriding example*/
            Console.WriteLine("..................................");
            Vehicle v1 = new Vehicle();
            v1.honk();
            Vehicle bmw= new Car();
            bmw.honk();
            Console.WriteLine("wheels on my car "+bmw.no_of_wheels);
            Console.WriteLine("Wheels on vehicle "+v1.no_of_wheels);
            Car ford = new Car();
            Console.WriteLine("wheels on my car " + ford.no_of_wheels);

            // data typecasting example
            TypeCastExample myobj = new TypeCastExample();
            myobj.cast();


            //Abstraction example
            Console.WriteLine("..................................");

            var submitobj = new Submit();
            submitobj.onclick();
            submitobj.squareroot();
            Console.WriteLine("Enter the shape of submit button");
            string s=Console.ReadLine();
            submitobj.Button_shape = s;
            Console.WriteLine($"The shape of the submit button is {submitobj.Button_shape}");
            Console.WriteLine("..................................");

            Iinterfacefly ibird = new Bird();
            Iinterfacefly iplane = new Aeroplane();
            ibird.fly();
            iplane.fly();
        }
    }
}
