using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customlist;

namespace Customlisttest
{
    [TestClass]
    public class UnitTest1
    {
        //Add Method
        #region
        [TestMethod]
        public void AddToList_PositiveNum_ExpectedPositiveNumForCount()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = 4;
            int actual;
            int expect = 1;
            //Act
            list.Add(num);
            actual = list.Count;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void AddString_String_ExpectedString()
        {
            MyList<string> list = new MyList<string>() { };
            //Arrange
            string word = "hi";
            string word2 = "world";
            string actual;
            string expect = "world";
            //Act
            list.Add(word);
            list.Add(word2);
            actual = list[1];
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckDataType_PositiveInteger_ExpectedPositiveInteger()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = 4;
            int actual;
            int expect = 4;
            //Act
            list.Add(num);
            actual = list[0];
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckCapacity_PositiveNum_ExpectedDoubleCapacity()
        {
            MyList<int> list = new MyList<int>() { };
            //arrange
            int actual;
            int expect = 8;
            //act
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(4);
            list.Add(7);
            actual = list.Capacity;
            //asseert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckOrder_PositiveNum_ExpectedInOrder()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            int index = 2;
            int actual;
            int expected = 8;
            //act
            list.Add(2);
            list.Add(5);
            list.Add(8);
            list.Add(0);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        //Indexer
        #region
        [TestMethod]
        public void CheckStringInList_Strings_ExpectedString()
        {
            MyList<string> list = new MyList<string>();
            //Arrange
            string actual;
            string expect = "hi";
            //Act
            list.Add("hi");
            actual = list[0];
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckIndex_At0_ExpectedValueOf0()
        {
            MyList<int> num = new MyList<int>();
            //arrange
            int actual;
            int expect = 2;
            //act
            num.Add(2);
            actual = num[0];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIndex_PositiveNum_ExpectIndexOutOfRange()
        {
            MyList<int> list = new MyList<int>();
            //Arrange
            int num = 6;
            //Act
            int expect = list[num];
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIndex_NegativeNum_ExpectIndexOutOfRange()
        {
            MyList<int> list = new MyList<int>();
            //Arrange
            int num = -6;
            //Act
            int expect = list[num];
        }
        #endregion

        //Remove
        #region
        [TestMethod]
        public void Remove_PositiveNum_ExpectRemoveFirstOccurrenceOnly()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            int actual;
            int expect = 4;
            //act
            list.Add(4);
            list.Add(3);
            list.Add(4);
            list.Add(2);
            list.Add(4);
            list.Remove(4);
            actual = list[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Remove_Value_ExpectCountDecrease()
        {
            MyList<string> list = new MyList<string>();
            //arrange
            string word = "hi";
            int actual;
            int expect = 0;
            //act
            list.Add(word);
            list.Remove("hi");
            actual = list.Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Remove_String_ExpectNotThatString()
        {
            MyList<string> list = new MyList<string>();
            //arrange
            string actual;
            string expect = "bye";
            //act
            list.Add("hello");
            list.Add("world");
            list.Add("bye");
            list.Remove("world");
            actual = list[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Remove_PositiveNum_ExpectSameOrder()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            int actual;
            int expect = 3;
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(2);
            actual = list[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_PositiveNum_ExpectRemoveLast()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(4);
            _ = list[3];
        }
        #endregion

        //To String
        #region
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ToString_Nothing_ExpectException()
        {
            MyList<string> list = new MyList<string>();
            //arrange
            string actual;
            //act
            actual = list.ToString();
        }
        [TestMethod]
        public void ToString_String_ExpectSameString()
        {
            MyList<string> list = new MyList<string>();
            //arrange
            string expect = "HelloWorld";
            string actual;
            //act
            list.Add("Hello");
            list.Add("World");
            actual = list.ToString();
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void ToString_Integers_ExpectStringOfIntegers()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            string expect = "12";
            string actual;
            //act
            list.Add(1);
            list.Add(2);
            actual = list.ToString();
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void ToString_Integers_ExpectCount()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            int expect = 2;
            int actual;
            //act
            list.Add(1);
            list.Add(2);
            list.ToString();
            actual = list.Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        #endregion

        //Overload Plus
        #region
        [TestMethod]
        public void OverloadPlus_TwoList_ExpectFirstListItemsFirst()
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> myList = new MyList<int>();
            //arrange
            int expect = 2;
            int actual;
            //act
            list.Add(1);
            list.Add(2);
            list2.Add(3);
            list2.Add(4);
            myList = list + list2;
            actual = myList[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void OverloadPlus_TwoList_ExpectIndexValueOfNewListToBeSame()
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> myList = new MyList<int>();
            //arrange
            int actual;
            int expect = 3;
            //act
            list.Add(1);
            list.Add(2);
            list2.Add(3);
            list2.Add(4);
            myList = list + list2;
            actual = myList[2];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void OverloadPlus_TwoList_ExpectNewCount()
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> myList = new MyList<int>();
            //arrange
            int expect = 5;
            int actual;
            //act
            list.Add(1);
            list.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            myList = list + list2;
            actual = myList.Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void OverloadPlus_TwoListOfStrings_ExpectNewListOfBothStrings()
        {
            MyList<string> list = new MyList<string>();
            MyList<string> list2 = new MyList<string>();
            MyList<string> myList = new MyList<string>();
            //arrange
            string expect = "test";
            string actual;
            //act
            list.Add("hi");
            list.Add("world");
            list2.Add("this");
            list2.Add("is");
            list2.Add("test");
            myList = list + list2;
            actual = myList[4];
            //assert
            Assert.AreEqual(expect, actual);
        }
        #endregion

        //Overload Minus
        #region
        [TestMethod]
        public void Minus_TwoList_ExpectCountToDecrease()
        {
            MyList<int> list = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            MyList<int> myList = new MyList<int>();
            //arrange
            int expect = 3;
            int actual;
            //act
            myList = list - list2;
            actual = myList.Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Minus_TwoList_ExpectItemsOfList2GoneFromNewList()
        {
            MyList<int> list = new MyList<int>() { 1, 2, 3, 4, 5, 6 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            MyList<int> myList = new MyList<int>();
            //arrange
            int expect = 3;
            int actual;
            //act
            myList = list - list2;
            actual = myList[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Minus_TwoListWithDifferentItems_ExpectNewListSameAsList1()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            MyList<int> myList = new MyList<int>();
            //arrange
            int expect = 3;
            int actual;
            //act
            myList = list - list2;
            actual = myList[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Minus_TwoListOfStrings_ExpectNewListOfStrings()
        {
            MyList<string> list = new MyList<string>() { "hi", "yay", "world" };
            MyList<string> list2 = new MyList<string>() { "yay" };
            MyList<string> myList = new MyList<string>();
            //arrange
            string expect = "world";
            string actual;
            //act
            myList = list - list2;
            actual = myList[1];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Minus_TwoList_ExpectExceptionArguementOutOfRange()
        {
            MyList<int> list = new MyList<int>() { 1, 2, 3 };
            MyList<int> list2 = new MyList<int>() { 3 };
            MyList<int> myList = new MyList<int>();
            //arrange
            //act
            myList = list - list2;
            _ = myList[2];
        }
        #endregion

        //Zip
        #region
        [TestMethod]
        public void Zip_2List_ExpectListOrder()
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> myList = new MyList<int>();
            MyList<int> holder = new MyList<int>();
            //arrange
            int expect = 1;
            int actual;
            int expect2 = 2;
            int actual2;
            //act
            list.Add(1);
            list.Add(3);
            list2.Add(2);
            list2.Add(4);
            holder = myList.Zip(list, list2);
            actual = holder[0];
            actual2 = holder[1];
            //assert
            Assert.AreEqual(expect, actual);
            Assert.AreEqual(expect2, actual2);
        }
        [TestMethod]
        public void Zip_2List_ExpectCountOfListPlusList2()
        {
            MyList<int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            MyList<int> bothList = new MyList<int>();
            //arrange
            int expect = 4;
            int actual;
            //act
            list.Add(1);
            list.Add(3);
            list2.Add(2);
            list2.Add(4);
            actual = bothList.Zip(list, list2).Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Zip_ListOfBiggerSize_ExpectToZipWithLongerList2()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6, 8, 9, 10 };
            //arrange
            int actual;
            int expect = 9;
            //act
            list.Zip(list2);
            actual = list[7];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Zip_ListOfBiggerSize_ExpectToZipWithLongList1()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5, 7, 8, 9 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            //arrange
            int actual;
            int expect = 8;
            //act
            list.Zip(list2);
            actual = list[7];
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Zip_List_ExpectCountToBeBothList()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            //arrange
            int actual;
            int expect = 7;
            //act
            list.Zip(list2);
            actual = list.Count;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Zip_List_ExpectListOrder()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            //arrange
            int actual;
            int actual2;
            int expect = 1;
            int expect2 = 2;
            //act
            list.Zip(list2);
            actual = list[0];
            actual2 = list[1];
            //assert
            Assert.AreEqual(expect, actual);
            Assert.AreEqual(expect2, actual2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Zip_List_ExpectException()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            //act
            list.Zip(list2);
            int actual = list[6];
        }
        [TestMethod]
        public void Zip_List_ExpectCombinedCapacity()
        {
            MyList<int> list = new MyList<int>() { 1, 3, 5 };
            MyList<int> list2 = new MyList<int>() { 2, 4, 6 };
            //arrange
            int actual;
            int expect = 8;
            //act
            list.Zip(list2);
            actual = list.Capacity;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Zip_ListOfString_ExpectZipStringList()
        {
            MyList<string> list = new MyList<string>() { "hi", "i", "greatest" };
            MyList<string> list2 = new MyList<string>() { "world", "am", "." };
            //arrange
            string actual;
            string expect = "hi";
            string actual2;
            string expect2 = "world";
            //act
            list.Zip(list2);
            actual = list[0];
            actual2 = list[1];
            //assert
            Assert.AreEqual(expect, actual);
            Assert.AreEqual(expect2, actual2);
        }
        #endregion
    }
}
