using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlist
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> concat = new MyList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list2.Add(2);
            list2.Add(4);
            list2.Add(2);
            list2.Add(8);
            list2.Add(2);
            list2.Add(12);
            list2.Add(14);
            list2.Clear();
            list.Zip(list2);
            Console.WriteLine(list);
        }
    }
}
