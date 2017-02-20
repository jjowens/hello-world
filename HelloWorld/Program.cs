using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            GoodByeWorld();

            Console.ReadLine();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void GoodByeWorld()
        {
            Console.WriteLine("Goodbye World");
        }
    }
}
