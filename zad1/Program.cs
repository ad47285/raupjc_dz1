using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntList;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList list = new IntegerList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //list.Clear();
            list.Add(4);
            list.Add(5);

            list.RemoveAt(0); // [2 ,3 ,4 ,5]
            list.Remove(5); // [2 ,3 ,4]
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove(100)); // false
            Console.WriteLine(list.RemoveAt(5)); // false
            list.Clear(); // []
            Console.WriteLine(list.Count); // 0

            Console.ReadKey();
        }
    }
}
