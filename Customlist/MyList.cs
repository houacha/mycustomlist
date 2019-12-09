using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Customlist
{
    public class MyList<T>: IEnumerable
    {
        private T[] customList;
        private int count;
        private int capacity;
        public MyList()
        {
            count = 0;
            capacity = 4;
            customList = new T[capacity];
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index <= count)
                {
                    return customList[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("'Can't touch this,' MC hammer");
                }
            }
            set
            {
                if (index >= 0 && index <= count)
                {
                    customList[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("'Can't touch this,' MC hammer");
                }
            }
        }
        public void Add(T item)
        {
            if (count != capacity)
            {
                customList[count] = item;
                count++;
            }
            else
            {
                T[] temp = new T[count];
                capacity *= 2;
                for (int j = 0; j < count; j++)
                {
                    temp[j] = customList[j];
                }
                customList = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    customList[i] = temp[i];
                }
                customList[count] = item;
                count++;
            }

        }
        public void Remove(T item)
        {
            T[] temp = new T[count];
            int firstItem = 0;
            int nextItem = 0;
            int countHold = count;
            if (count > 0)
            {
                for (int i = 0; i < countHold; i++)
                {
                    if (customList[i].Equals(item) && firstItem == 0)
                    {
                        firstItem = 1;
                        count--;
                    }
                    else if (nextItem == 0 && firstItem == 1)
                    {
                        temp[nextItem] = customList[i];
                        nextItem++;
                    }
                    else
                    {
                        temp[nextItem] = customList[i];
                        nextItem++;
                    }
                }
            }
            customList = new T[count];
            for (int j = 0; j < count; j++)
            {
                customList[j] = temp[j];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return customList.GetEnumerator();
        }
    }
}
