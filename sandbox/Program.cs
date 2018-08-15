using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            List<string> alist = new List<string>
            {
                "tyger", "tyger", "burning", "bright"
            };

            //doesn't work
            //List<string> newList = alist.RemoveAll();
            //neither does .Clear()
            // or this
            //List<string> newList = new List<string>();
            //    alist.CopyTo();

            //the following works
            List<string> newList = alist.Take(alist.Count).ToList();

            foreach (string str in alist)
            {
                Console.WriteLine(str);
            }
            //may work with mods
            //alist.foreach (var item in alist)
            //{
            //    newList.Add(item);
            //};

            Console.ReadLine();
        }
    }
}
