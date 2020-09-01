using System;
using System.Linq;

namespace CSharpKatasLibrary
{
    public class ArrayKatas
    {
        public static int getLastItemInArrayByOverloading(int[] itemArray)
        {
            return itemArray[itemArray.Length - 1];
        }

        public static string getLastItemInArrayByOverloading(string[] itemArray)
        {
            return itemArray[itemArray.Length - 1];
        }

        public dynamic getLastItemInArray<T>(T[] itemArray)
        {
            return itemArray[itemArray.Length - 1];
        }

        public static int getLastItemInArrayUsingLinq(int[] itemArray)
        {
            return itemArray.Last();
        }
    }
}
