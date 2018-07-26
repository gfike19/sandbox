using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> test = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                int rnum = getRandomNum();
                test.Add(rnum);
            }

            foreach(int i in test)
            {
                Console.Write(i + ", ");
            }

            test.Sort();
            Console.WriteLine("\n");

            foreach (int i in test)
            {
                Console.Write(i + ", ");
            }

            Console.ReadLine();
        }
        //true random numbers
        public static int getRandomNum ()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            int randomInteger = (int)BitConverter.ToUInt32(byteArray, 0) % 10;
            return randomInteger;
        }
    }
}
