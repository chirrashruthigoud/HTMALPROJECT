using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class LinkedlistD
    {
        public void LinkedlistMethod()
        {
            LinkedList<int> linked = new LinkedList<int>();
            linked.AddLast(1);
            linked.AddLast(2);
            linked.AddLast(3);
            linked.AddLast(4);
            linked.AddLast(5);
            linked.AddLast(6);

            //foreach(int a in linked)
            //{
            //    Console.WriteLine($"{a}");
            //}
            //addfirst
            linked.AddFirst(10);
            linked.AddFirst(20);
            linked.AddFirst(30);
            linked.AddFirst(40);
            Console.WriteLine("count :" + linked.Count);

            //foreach (int a in linked)
            //{
            //    Console.WriteLine($"{a}");
            //}
            //clear
            //linked.Clear();

            linked.Remove(linked.Last);
            linked.Remove(30);
            linked.RemoveFirst();
            linked.RemoveLast();
            foreach (int a in linked)
            {
                Console.WriteLine($"{a}");
            }
            Console.WriteLine($"count : " + linked.Count);

        }

    }
}
