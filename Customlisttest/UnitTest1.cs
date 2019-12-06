using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customlist;

namespace Customlisttest
{
    [TestClass]
    public class UnitTest1
    {
        //Add Method
        [TestMethod]
        public void AddToList_PositiveNum_ExpectedPositiveNumForCount()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = 4;
            int actual = list.Count;
            int expect = 1;
            //Act
            list.Add(num);
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
            string actual = list[1];
            string expect = "world";
            //Act
            list.Add(word);
            list.Add(word2);
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckDataType_PositiveInteger_ExpectedPositiveInteger()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = 4;
            int actual = Int32.TryParse(list[0], out int result); 
            int expect = 4;
            //Act
            list.Add(num);
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckSpecificindex_PositiveNum_ExpectedPositiveNumOfIndex()
        {
            MyList<int> list = new MyList<int>() { };
            //arrange
            int num = 3;
            int actual list[num];
            int expect = 4;
            //act
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(4);
            list.Add(7);
            //asseert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void 

        //Indexer
        [TestMethod]
        public void CheckStringInList_Strings_ExpectedString()
        {
            MyList<string> list = new MyList<string>() { };
            //Arrange
            string word = "hi";
            string actual = list.customList[0];
            string expect = "hi";
            //Act
            list.IndexAt(word);
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void CheckIndex_At0_ExpectedValueOf0()
        {
            MyList<int> num = new MyList<int>() { };
            //arrange
            int number = 9;
            int actual = num.customList[0];
            int expect = 9;
            //act
            MyList.IndexAt(0);
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIndex_PositiveNum_ExpectIndexOutOfRange()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = 6;
            //Act
            list.IndexAt(num);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIndex_NegativeNum_ExpectIndexOutOfRange()
        {
            MyList<int> list = new MyList<int>() { };
            //Arrange
            int num = -6;
            //Act
            list.IndexAt(num);
        }
        [TestMethod]
        public void F() { }

        //Remove
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt0_PositiveNum_ExpectIndexOutOfRange()
        {
            MyList<int> list = new MyList<int>();
            //arrange

            //act

            //assert

        }
    }
}
