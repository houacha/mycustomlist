﻿using System;
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
            // First lists
            MyList<int> nums = new MyList<int>() { 1, 3, 5, 3};
            MyList<string> list = new MyList<string> { "hi", "hello", "bonjour", "world" };
            MyList<int> numberList = new MyList<int> { 2, 3, 4, 5, 6, };

            // Second lists
            MyList<int> nums2 = new MyList<int>() { 3, 5 };
            MyList<string> list2 = new MyList<string> { "hi", "bonjour" };
            MyList<int> numberList2 = new MyList<int> { 3, 4, 5 };

            // Resulting lists
            MyList<int> numsResult = new MyList<int>();
            MyList<string> listResult = new MyList<string>();
            MyList<int> numberListResult = new MyList<int>();


            numsResult = nums - nums2;
            listResult = list - list2;
            numberListResult = numberList - numberList2;


            Console.WriteLine(numsResult);
            Console.WriteLine(listResult);
            Console.WriteLine(numberListResult);
            // 1
            // hiworld
            // 26
        }
    }
}
