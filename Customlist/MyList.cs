using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Customlist
{
    public class MyList<T> : IEnumerable
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
                if (index >= 0 && index < count)
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
                if (index >= 0 && index < count)
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
            T[] temp;
            if (count == capacity)
            {
                capacity *= 2;
                temp = new T[capacity];
                for (int j = 0; j < count; j++)
                {
                    temp[j] = customList[j];
                }
                customList = temp;
            }
            customList[count] = item;
            count++;
        }
        public bool Remove(T item)
        {
            T[] temp = new T[count];
            int firstItem = 0;
            int nextItem = 0;
            int countHold = count;
            bool removed = false;
            if (count > 0)
            {
                for (int i = 0; i < countHold; i++)
                {
                    if (customList[i].Equals(item) && firstItem == 0)
                    {
                        firstItem = 1;
                        removed = true;
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
            customList = temp;
            return removed;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return customList[i];
            }
        }
        public override string ToString()
        {
            if (count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(customList[i]);
                }
                return stringBuilder.ToString();
            }
            else
            {
                throw new Exception("No Strings Attached");
            }
        }
        public static MyList<T> operator +(MyList<T> list, MyList<T> list2)
        {
            MyList<T> concatLists = new MyList<T>();
            for (int i = 0; i < list.count; i++)
            {
                concatLists.Add(list[i]);
            }
            for (int j = 0; j < list2.count; j++)
            {
                concatLists.Add(list2[j]);
            }
            return concatLists;
        }
        public static MyList<T> operator -(MyList<T> list, MyList<T> list2)
        {
            MyList<T> combinedList = new MyList<T>();
            for (int i = 0; i < list.count; i++)
            {
                combinedList.Add(list[i]);
            }
            for (int j = 0; j < list2.count; j++)
            {
                combinedList.Remove(list2[j]);
            }
            return combinedList;
        }
        public MyList<T> Zip(MyList<T> list, MyList<T> list2)
        {
            MyList<T> zipped = new MyList<T>();
            int counter;
            if (list2.count > list.count)
            {
                counter = list2.count;
            }
            else
            {
                counter = list.count;
            }
            for (int i = 0; i < counter; i++)
            {
                if (list.count > list2.count && i >= list2.count)
                {
                    zipped.Add(list[i]);
                }
                else if (list2.count > list.count && i >= list.count)
                {
                    zipped.Add(list2[i]);
                }
                else
                {
                    zipped.Add(list[i]);
                    zipped.Add(list2[i]);
                }
            }
            return zipped;
        }
        public void Zip(MyList<T> list)
        {
            int newCount = count + list.count;
            int loopAmount;
            T[] zippedList = new T[newCount];
            int nextIndex = 0;
            if (count < list.count)
            {
                loopAmount = list.count;
            }
            else
            {
                loopAmount = count;
            }
            for (int i = 0; i < loopAmount; i++)
            {
                if (count > list.count && i >= list.count)
                {
                    zippedList[nextIndex] = customList[i];
                    nextIndex++;
                }
                else if (count < list.count && i >= count)
                {
                    zippedList[nextIndex] = list[i];
                    nextIndex++;
                }
                else
                {
                    zippedList[nextIndex] = customList[i];
                    nextIndex++;
                    zippedList[nextIndex] = list[i];
                    nextIndex++;
                }
            }
            customList = new T[newCount];
            count = newCount;
            capacity = list.capacity + capacity;
            for (int j = 0; j < newCount; j++)
            {
                customList[j] = zippedList[j];
            }
        }
        public void RemoveAt(int index)
        {
            T[] temp = new T[count];
            int countHold = count;
            int currentIndex = 0;
            if (count > 0)
            {
                for (int i = 0; i < countHold; i++)
                {
                    if (i != index)
                    {
                        temp[currentIndex] = customList[i];
                        currentIndex++;
                    }
                    else
                    {
                        count--;
                    }
                }
                customList = new T[count];
                for (int j = 0; j < count; j++)
                {
                    customList[j] = temp[j];
                }
            }
        }
        public void RemoveAll(T item)
        {
            T[] temp = new T[count];
            int countHold = count;
            int currentIndex = 0;
            if (count > 0)
            {
                for (int i = 0; i < countHold; i++)
                {
                    if (customList[i].Equals(item))
                    {
                        count--;
                    }
                    else
                    {
                        temp[currentIndex] = customList[i];
                        currentIndex++;
                    }
                }
                customList = new T[count];
                for (int j = 0; j < count; j++)
                {
                    customList[j] = temp[j];
                }
            }
        }
        public void AddAt(int index, T item)
        {
            T[] temp = new T[count + 1];
            int currentIndex = 0;
            int countHold = count;
            if (count == capacity)
            {
                capacity *= 2;
            }
            for (int i = 0; i < countHold; i++)
            {
                if (i == index)
                {
                    temp[currentIndex] = item;
                    currentIndex++;
                    count++;
                }
                temp[currentIndex] = customList[i];
                currentIndex++;
            }
            customList = new T[count];
            for (int j = 0; j < count; j++)
            {
                customList[j] = temp[j];
            }
        }
        public void Replace(int index, T item)
        {
            T[] temp = new T[count];
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    temp[i] = item;
                }
                else
                {
                    temp[i] = customList[i];
                }
            }
            customList = new T[count];
            for (int j = 0; j < count; j++)
            {
                customList[j] = temp[j];
            }
        }
        public void Replace(T currentItem, T itemToReplace)
        {
            T[] temp = new T[count];
            bool firstItem = true;
            for (int i = 0; i < count; i++)
            {
                if (customList[i].Equals(currentItem) && firstItem == true)
                {
                    temp[i] = itemToReplace;
                    firstItem = false;
                }
                else
                {
                    temp[i] = customList[i];
                }
            }
            customList = new T[count];
            for (int j = 0; j < count; j++)
            {
                customList[j] = temp[j];
            }
        }
        public void ReplaceAll(T currentItem, T itemToReplace)
        {
            T[] temp = new T[count];
            for (int i = 0; i < count; i++)
            {
                if (customList[i].Equals(currentItem))
                {
                    temp[i] = itemToReplace;
                }
                else
                {
                    temp[i] = customList[i];
                }
            }
            customList = new T[count];
            for (int j = 0; j < count; j++)
            {
                customList[j] = temp[j];
            }
        }
        public bool Contains(T item)
        {
            bool doesContain = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (customList[i].Equals(item))
                    {
                        doesContain = true;
                        break;
                    }
                    else
                    {
                        doesContain = false;
                    }
                }
            }
            else
            {
                doesContain = false;
            }
            return doesContain;
        }
        public MyList<int> IndexOf(T item)
        {
            MyList<int> index = new MyList<int>();
            bool doesContain = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (customList[i].Equals(item))
                    {
                        index.Add(i);
                        doesContain = true;
                    }
                }
            }
            else
            {
                throw new Exception("You do not have a list to check.");
            }
            if (doesContain == false)
            {
                throw new Exception("List does not contain the item.");
            }
            return index;
        }
        public int AmountOf(T item)
        {
            int amount = 0;
            for (int i = 0; i < count; i++)
            {
                if (customList[i].Equals(item))
                {
                    amount++;
                }
            }
            return amount;
        }
        public void Clear()
        {
            count = 0;
            capacity = 0;
            customList = new T[capacity];
        }
    }
}
