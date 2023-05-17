using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* LinkedListNode list = new LinkedListNode();
            Console.WriteLine("select the following");
            Console.WriteLine("1.Add element to linked list.\n2.Add element in reverse.\n3.Remove First Element\n4.Remove last element" +
                "\n5.Size of LinkedList \n6.create linkedlist. \n7.Queue adding value. ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.ToDisplay();
                    break;
                case 2:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.ToDisplay();

                    break;
                case 3:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.Removeatfirst();
                    list.ToDisplay();
                    break;
                case 4:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.RemoveLast();
                    list.ToDisplay();
                    break;
                case 5:
                    list.AddInReverseOrder(90);
                    list.AddInReverseOrder(100);
                    list.AddInReverseOrder(110);
                    list.Size();
                    break;
                case 6:
                    LinkedlistD linkedlistD = new LinkedlistD();
                    linkedlistD.LinkedlistMethod();
                    break;
                case 7:
                    QueueExample queue = new QueueExample();
                    queue.QueueMethod();
                    queue.QueueGenerics();
                    break;

                default:
                    Console.WriteLine("Element is invalid");
                    break;
            }*/

            ArrayReverseHihellow obj= new ArrayReverseHihellow();
            obj.Methodarray();
            Console.ReadLine();
        }
    }
    
}
