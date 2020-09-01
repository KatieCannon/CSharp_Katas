using System;
namespace CSharpKatasLibrary
{
    public class ArrayKatas
    {
        public static string getLastItemInArray(string[] nameArray)
        {
            return nameArray[nameArray.Length -1];
        }

        public static int getLastItemInArray(int[] nameArray)
        {
            return nameArray[nameArray.Length - 1];
        }
    }
}
