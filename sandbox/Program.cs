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
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            int randomInteger = (int)BitConverter.ToUInt32(byteArray, 0) % 9;
            List<int> listOfLists = new List<int>();

            for(int i = 0; i < randomInteger; i++)
            {

            }
        }
    }
}
