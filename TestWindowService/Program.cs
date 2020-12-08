using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowService
{
    class Program
    {
        static void Main(string[] args)
        {
            var myService = new WindowsService1.Service1();
            myService.Verify(args);
        }
    }
}
