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

        public static string getLastItemInArrayUsingLinq(string[] itemArray)
        {
            return itemArray.Last();
        }

        public static int[] addAmountToAll(int[] numbersArray, int addValue)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                 numbersArray[i] += addValue;
            }
            return numbersArray;
        }
    }
}
