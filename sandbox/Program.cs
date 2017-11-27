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
            int user_count = 0;

            while (user_count < 20 && user_count == 0)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    user_count += i;
                    Console.WriteLine(i + " has been added!");
                }
                i++;
            }
        }
    }
}
