using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    internal class ArrayListDemo
    {
        public void arraylistdemo()
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add("shruthi");
            arraylist.Add(3);
            arraylist.Add(5);
            arraylist.Add(6);
            //insert
            // arraylist.Insert(0,9);
            //arraylist.Insert(1,67);
            //remove
            //arraylist.Remove(6);
            //arraylist.RemoveAt(4); //it will remove the data accoding to index
            //--removerange
            arraylist.RemoveRange(0, 3);//it will remove the first 3 count
            int count = arraylist.Count;
            Console.WriteLine("count" + count);

            //arraylist.Clear();
            //int counts = arraylist.Count;
            //Console.WriteLine("count" + count);

            arraylist.Sort();
            //Console.WriteLine(arraylist);
            foreach (var i in arraylist)
            {
                Console.WriteLine(i);
            }

            //for loop
            Console.WriteLine("----for loop----");
            for (int i = 0; i < arraylist.Count; i++) //we can use only count(index)
            {
                // Console.WriteLine(i);//by using this we can only index.
                Console.WriteLine(arraylist[i]);
            }
        }
    }
}
