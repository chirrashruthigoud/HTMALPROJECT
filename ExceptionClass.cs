using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class ExceptionClass
    {
        public void ExceptionMethod()
        {
            var filename = "word.txt";
            if (File.Exists(filename))
            {
                var content = File.ReadAllText(filename);
                Console.WriteLine(content);

            }
            try
            {
                var contents = File.ReadAllText(filename);
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("failed to read file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
