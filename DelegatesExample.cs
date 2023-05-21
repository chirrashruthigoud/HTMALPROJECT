using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class DelegatesExample
    {
        public static void FirstMethods(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void SecondMethods(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
namespace DelegatesDemo
{
    //a  refernce type variable that hold the referce type to a method
    //we are uing events and triggers for delegates.
    //when you work on delegate we need a return type.
    //whenever we work on Multiple delegate we don't need return tyoe we use void
    //the return type of delegate should be same as method return type

    public class DelegatesClass
    {
        public int FirstMethod(int x, int y)
        {
            return x + y;
        }
        public int SecondMethod(int x, int y)
        {
            return x - y;
        }
    }
}
//program
namespace DelegatesDemo
{
    public delegate int DelegateDemo(int x, int y);
    public delegate void MultiDelegateDemo(int x, int y);

    public class Program
    {
        public static void Main(string[] args)
        {
            DelegatesClass Class = new DelegatesClass();

            //DelegateDemo del = new DelegateDemo(Class.FirstMethod);
            //Console.WriteLine( del(25, 5));
            //DelegateDemo dele = new DelegateDemo(Class.SecondMethod);
            //Console.WriteLine(del(25, 50));
            //Console.WriteLine(Class.FirstMethod(50,63));
            //Console.WriteLine(Class.SecondMethod(20,30));

            //MultipleDelegates multiple = new MultipleDelegates();
            //MultiDelegateDemo multipleDelegates = new MultiDelegateDemo(MultipleDelegates.FirstMethods);
            //MultiDelegateDemo multipleDelegates = MultipleDelegates.FirstMethods;
            MultiDelegateDemo multiDelegate = MultipleDelegates.FirstMethods;
            multiDelegate += MultipleDelegates.SecondMethods;
            // multiDelegate += MultipleDelegates.FirstMethods;
            multiDelegate(20, 3);
            Console.ReadLine();
        }
    }
}
    }
}
