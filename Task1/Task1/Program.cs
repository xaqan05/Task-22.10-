using Task1.Helpers;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "zxa qan";

           int[] arr =  str.GetValueIndexes('a');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
