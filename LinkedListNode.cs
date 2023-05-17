using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HtmlProjectProgram
{
    public class LinkedListNode
    {
        public Node head;//empty node
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;//storing last data in temp variable
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Linkedlist", node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} added in reverse order in linkedlist", newNode.data);
        }
        //remove first node.
        public void Removeatfirst()
        {
            if (head == null)
            {
                Console.WriteLine("linkedlist is empty");
            }
            this.head = this.head.next;
            Console.WriteLine("First element deleted.");
        }
        //remove last node.
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("liked list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node lastnode = this.head;
            while (lastnode.next.next != null)
            {
                lastnode = lastnode.next;
            }
            lastnode.next = null;
            Console.WriteLine("linked list remove last.");
        }

        public void Size()
        {
            Node temp = head;
            int count = 0;
            if (head == null)
            {
                Console.WriteLine("linked list empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                count++;
            }
            Console.WriteLine("the count will be : " + count);
        }

        //display.
        public void ToDisplay()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
