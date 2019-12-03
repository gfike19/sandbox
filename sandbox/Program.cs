using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            //int i = 0;
            int user_input = 0;
            //int off_count = 0;
            do
            {
                int r = RNum();

                while (Console.KeyAvailable == false)
                {
                    Console.WriteLine(r);
                    Thread.Sleep(1000);
                }

r = RNum();
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    user_input += r;
                    //off_count++;
                    Console.WriteLine("The user took " + r);
                    
                }
            } while (cki.Key != ConsoleKey.Escape);
            Console.WriteLine("Total is: " + user_input + "\nPress Enter to exit");
            Console.ReadLine();
        }

        private static int RNum()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            //convert 4 bytes to an integer
            var randomInteger = BitConverter.ToUInt32(byteArray, 0);

            return (int)randomInteger;
        }
    }
}
