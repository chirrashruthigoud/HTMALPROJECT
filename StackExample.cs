using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class StackExample
    {
        public void StackMethod()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            foreach (int i in stack)
            {
                Console.WriteLine("Stack elements:" + i);
            }
            Console.WriteLine("pop element" + stack.Pop());
            Console.WriteLine("peek element:" + stack.Peek());
        }
    }
}
