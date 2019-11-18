using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace hk
{
    class powersystem1
    {
        static void Main1(string[] args)
        {
            int n;
            int c = 1;
            Console.WriteLine("Enter the number of power systems");
            n = ToInt32(ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ToInt32(ReadLine());
            }
         
            
          
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (j > 0)
                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                            j = -1;
                        }
                    }
                }
            }

            int[] arr2 = new int[c];

        }
       
    }
}
