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
        //works but don't know why off count is needed
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int i = 0;
            int user_input = 0;
            int off_count = 0;
            do
            {

                while (Console.KeyAvailable == false)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                    i++;
                }
                    

                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    user_input += i;
                    off_count++;
                    Console.WriteLine("The user took " + (i - 1));
                }
            } while (cki.Key != ConsoleKey.Escape);
            Console.WriteLine("Total is: " + (user_input - off_count) + "\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
