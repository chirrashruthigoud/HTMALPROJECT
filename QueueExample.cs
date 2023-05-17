using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class QueueExample
    {
        public void QueueMethod()
        {
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(23);
            queue.Enqueue(30);
            queue.Enqueue(44);

            var remove = queue.Dequeue();
            Console.WriteLine(remove);
            foreach (var item in queue)
            {
                Console.WriteLine("Queue elenents :" + item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine("dequeue elements:" + item);
            }
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(15));
        }
        public void QueueGenerics()
        {
            Queue<double> name = new Queue<double>();
            name.Enqueue(1.25);
            name.Enqueue(2.05);
            name.Enqueue(3.54);
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(name.Peek());

        }
    }
}
