using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace hk
{
    class Reverse
    {
        static void Main1(string[] args)
        {
            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = ToInt32(ReadLine());
            //}
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            string rev = "";
            string str = "Ramadevi";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                
                rev += str[i].ToString();
                
            }
            Console.WriteLine(rev);
            //int  Length = str.Length - 1;
            //  string reverse = "";
            //  while (Length >= 0)
            //  {
            //      reverse = reverse + str[Length];
            //      Length--;
            //  }
            //  Console.WriteLine(reverse);
        }
    }
}
