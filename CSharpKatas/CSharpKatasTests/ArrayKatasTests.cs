using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpKatasLibrary;

namespace CSharpKatasTests
{
    
    [TestClass]
    public class ArrayKatasTests
    {
        
        [TestMethod]
        public void getLastNameInArray()
        {
            string[] nameArray = { "apple", "orange", "banana" };

            string result = ArrayKatas.getLastItemInArray(nameArray);

            Assert.AreEqual("banana", result);
        }

        [TestMethod]
        public void getLastNumberInArray()
        {
            int[] numberArray = { 1, 2, 3 };

            int result = ArrayKatas.getLastItemInArray(numberArray);

            Assert.AreEqual(3, result);
        }
    }
}

