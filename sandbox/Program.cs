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
            List<List<int>> listOfLists = new List<List<int>>();

            //create list of lists that has random nunbers
            while (listOfLists.Count < 5)
            {
                List<int> temp = new List<int>();

                for (int j = 0; j < 10; j++)
                {
                    int rnum = getRandomNum();
                    temp.Add(rnum);
                }
                listOfLists.Add(temp);
            }

            //display original list of lists
            foreach(List<int> each in listOfLists)
            {
                Console.Write("[");
                foreach(int num in each)
                {
                    Console.Write(num + ", ");
                }
                Console.Write("]\n\n");
            }

            List<int> collated = new List<int>();

            for(int i = 0; i < 10; i ++)
            {
                foreach(List<int> lst in listOfLists)
                {
                    collated.Add(lst[i]);
                }
            }

            Console.Write("\n\n");
            foreach(int num in collated)
            {
                Console.Write(num + ", ");
            }

            Console.ReadLine();
        }


        public static int getRandomNum()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            int randomInteger = (int)BitConverter.ToUInt32(byteArray, 0) % 10;
            return randomInteger;
        }
    }
}
