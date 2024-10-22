using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Helpers
{
    public static class ExtentionMethods
    {
        public static string toCapitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);   
        }

        public static int[] GetValueIndexes(this string str, char c)
        {
            int[] arr = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }

     
    }
}
