using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlist
{
    public class MyList<T>
    {
        public T[] customList;
        private int count;
        public MyList()
        {
            count = 0;
            customList = new T[4];
        }
        public int Count {
            get
            {
                return count;
            }
        }


    }
}
