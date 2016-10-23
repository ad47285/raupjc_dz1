using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenList;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> list = new GenericList<double>();
            list.Add(1.2);
            list.Add(5.2);
            list.Add(3);
            //list.Clear();
            list.Add(4);
            list.Add(5);

            list.RemoveAt(0); // [2 ,3 ,4 ,5]
            list.Remove(5); // [2 ,3 ,4]
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove(100)); // false
            Console.WriteLine(list.RemoveAt(1)); // false
            //list.Clear(); // []
            Console.WriteLine(list.Count); // 0

            list.test();
            Console.ReadKey();
        }
    }
}
