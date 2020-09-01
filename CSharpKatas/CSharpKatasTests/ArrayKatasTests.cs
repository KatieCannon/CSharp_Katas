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

            string result = ArrayKatas.getLastNameInArray(nameArray);

            Assert.AreEqual("banana", result);
        }
    }
}

