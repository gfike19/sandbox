using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                    i++;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
        }
    }
}
