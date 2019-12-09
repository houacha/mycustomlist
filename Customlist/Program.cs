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
            MyList<int> nums = new MyList<int>() { 1, 3, 5 };
            MyList<int> nums2 = new MyList<int>() { 2, 4, 6, };
           // nums.Zip(nums2);
            foreach(int numbers in nums)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
