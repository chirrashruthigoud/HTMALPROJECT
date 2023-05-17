using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class OopsConcepts
    {
        public void Addmethod(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("Number :" + add);
        }
        public void Nonparameterized()
        {
            int a = 60; int b = 6;
            int div = a / b;
            Console.WriteLine(div);
            Console.WriteLine("shruthi");
        }
    }

    // Inheriting from Interface Class
    public class InheritanceDemo : InterfaceDemo
    {
        public void methodOne()
        {
            Console.WriteLine("This is a interface method");
        }
    }


        //Abstraction is a way hiding unecessary details and showing only relavent information
        //we can achieve it with abstract class and abstract method using abstract keyword
        //we can't create object of abstract class
        // abstract and non-abstract method both are present in abstract class
        public abstract class AbstractionDemo
        {
            //Abstract method
            public abstract void methodAbstract();

            //Normal method
            public void methodNormal()
            {
                Console.WriteLine("Noraml method");
            }
        }

    //It is a way of hiding sensitive data from users
    //Fields declared should be private
    // Property get is only Read only
    // Property set is write only
    public class Encapsulation
    {
        private string name = "Bruce Wayne";

        // providing getters and setters method
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Automatic property
        public int RollNo { get; set; }
    }
    public class EnumDemo
    {
    }
    // Enum is a special class used to define constants
    enum Members
    {
        Abhi,
        Bruce,
        Clark,
        Smith
    }

    // Interface is a class that has only abstract method.
    // We can't create object from interface class.
    // Private members are not allowed.
    //By default interface members are abstract and public
    public interface InterfaceDemo
    {
        void methodOne(); //Method doesn't have implementation
    }


    //Polymorphism means many form and there are two types of polymorphism
    //1.Run time Polymorphism --> Method OverRiding
    //2.Compile Type PolyMorphism --> Method OverLoading
    public class OverLoading
    {
        //Compile Time => It Contains many functions or methods with different parameters
        public void MethodOne()
        {
            Console.WriteLine("without parameter");
        }
        public void MethodOne(int num)
        {
            Console.WriteLine("With one parameter");
        }
        public void MethodOne(int num, string str)
        {
            Console.WriteLine("With two parameter");
        }
        public void MethodOne(string str, int num)
        {
            Console.WriteLine("With two parameter");
        }
    }
    //refernce
    public class ReferenceType
    {
        public void ReferenceMethod(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);

        }
    }

    // Type casting is used to assign a value of one data type to another data type
    // There are two types 1.Implicit Casting 2. Explicit Casting
    //1. Implicit means automatically converting a small type to a large type
    // char -> int -> long -> float -> double
    //2. Explicit means manually converting a small type to a large type
    //double -> int
    public class TypeCasting
    {
        public void Method()
        {
            //Implicit
            int num = 12;
            double numTwo = num;
            Console.WriteLine(numTwo);
            Console.WriteLine(num);

            //Explicit
            double val = 10.5;
            int valTwo = (int)val;
            Console.WriteLine(valTwo);
        }
    }

    //Value type is of two types
    //1.Built in type: It will store in the stack memory --> int,long float ,double , byte , char , bool
    //2.User Defined type --> struct , enum
    public class ValueType
    {
        public void ValueTypeMethod()
        {
            //Value type
            int numOne = 12;
            int numTwo = numOne;
            numTwo++;
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
        }
    }

    public class Overriding
    {

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog : Overriding
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
   

}
