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
        public void CheckSpecificindex_PositiveNum_ExpectedPositiveNumOfIndex()
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
            int expect = 3;
            //act
            list.Add(4);
            list.Add(3);
            list.Add(4);
            list.Add(2);
            list.Add(4);
            list.Remove(4);
            actual = list[0];
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
            list.Remove();
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
        public void Remove_PositiveNum_ExpectRemoveFirstOnly()
        {
            MyList<int> list = new MyList<int>();
            //arrange
            int expect = 2;
            int actual;
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove();
            actual = list[0];
            //assert
            Assert.AreEqual(expect, actual);
        }
        #endregion

        //to string
        #region
        [TestMethod]
        public void ToString_String_ExpectSameString()
        {
            MyList<string> list = new MyList<string>();
            //arrange
            string expect = "Hello,World";
            //act
            list.Add("Hello");
            list.Add("World");
            list.ToString();
            //assert
            Assert.IsTrue(list);
        }
        #endregion
    }
}
