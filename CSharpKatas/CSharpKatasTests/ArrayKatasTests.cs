using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpKatasLibrary;

namespace CSharpKatasTests
{
    
    [TestClass]
    public class ArrayKatasTests
    {
        [TestMethod]
        public void getLastNumberInArray()
        {
            int[] numberArray = { 1, 2, 3 };

            int result = ArrayKatas.getLastItemInArrayByOverloading(numberArray);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void getLastNameInArray()
        {
            string[] nameArray = { "apple", "orange", "banana" };

            string result = ArrayKatas.getLastItemInArrayByOverloading(nameArray);

            Assert.AreEqual("banana", result);
        }

        [TestMethod]
        public void getLastNameItemInArray()
        {
            ArrayKatas arrayKata = new ArrayKatas();

            string[] nameArray = { "apple", "orange", "banana" };

            string result = arrayKata.getLastItemInArray(nameArray);

            Assert.AreEqual("banana", result);
        }

        [TestMethod]
        public void getLastNumberItemInArray()
        {
            ArrayKatas arrayKata = new ArrayKatas();

            int[] numberArray = { 1, 2, 3 };

            int result = arrayKata.getLastItemInArray(numberArray);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void getLastNumberInArrayUsingLinq()
        {
            int[] numbersArray = { 1, 2, 3 };

            int result = ArrayKatas.getLastItemInArrayUsingLinq(numbersArray);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void getLastNameInArrayUsingLinq()
        {
            string[] nameArray = { "apple", "orange","banana" };

            string result = ArrayKatas.getLastItemInArrayUsingLinq(nameArray);

            Assert.AreEqual("banana", result);
        }
    }
}

