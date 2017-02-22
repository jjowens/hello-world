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
            Console.WriteLine(DateTime.Now.ToUKDate());

            HelloWorld();
            GoodByeWorld();
            BrB();

            Console.ReadLine();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World {0}", DateTime.Now.ToShortTimeString());
        }

        static void GoodByeWorld()
        {
            Console.WriteLine("Goodbye World {0}", DateTime.Now.ToShortTimeString());
        }

        static void BrB()
        {
            Console.WriteLine("Be right back!");
        }
    }
}
