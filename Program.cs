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
            DictionaryProblem example = new DictionaryProblem();
            example.DictionaryMethod();
            //linked list is the liner datastructure
            //it consist of group of node in sequence
            //node consist of two parts
            //data and address
            //data:-each node of a linked list can store a data.
            //address:each node of a linkedlist can take a address of the next node(next)

            LinkedlistD linkedlistD = new LinkedlistD();
            linkedlistD.LinkedlistMethod();
            Console.ReadLine();
        }
    }
    
}
