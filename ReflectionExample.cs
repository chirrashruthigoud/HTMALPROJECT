using HtmlProjectProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class ReflectionExample
    {
        public static void Customer()
        {
            Type type = Type.GetType("ReflectionProgram.Customer");
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Assembly);
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }

            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.ToString());
            }

            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name + " " + methodInfo.ReturnType);
            }

        }
    }
}
//Class

//namespace ReflectionProgram
//{
//    public class Customer
//    {
//        public int a, b;
//        public int Id
//        {
//            get; set;
//        }
//        public string Name
//        {
//            get; set;
//        }
//        public Customer()
//        {
//            Id = 121;
//            Name = "sunny";
//        }
//        public Customer(int id)
//        {
//            Id = id;
//        }
//        public void CustomerMethod()
//        {
//        }
//        public void CustomerMethods(int Id)
//        {
//        }

//    }
//}
////Program class
//public static void Main(string[] args)
//{
//    CustomerInfo.Customer();
//    Console.ReadLine();
//}
