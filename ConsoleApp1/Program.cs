using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            //Console.WriteLine(args[0]);

            using (var sw = new StreamWriter(args[0]))
            {
                sw.WriteLine("Welcome to Windows Service in .NET");
            }
            
            Console.ReadKey();
        }
    }
}
