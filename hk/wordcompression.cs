using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace hk
{
    class wordcompression
    {
        static void Main1(string[] args)
        {
            string str;
            str = ReadLine();
            string new_str = "";
            //char c;
            Console.WriteLine("enter a number");
            int k = ToInt32(ReadLine());
            int m = 1;
            for (int i = 0; i < str.Length-1; i++)
            {
                 if (str[i] == str[i+1])
                    {
                        m++;
                    }
                
            }
            for (int i = 0; i < str.Length-1; i++)
            {
                if (m == k)
                {
                    //c = str[i];
                    new_str=str.Remove(i, k);
                }
              
            }
            for (int i = 0; i < new_str.Length; i++)
            {
                Console.WriteLine(new_str[i]);
            }
            ReadLine();



            //for(int i=0;i<str.Length;i++)
            //{
            //    str.Remove()
            //}
        }
    }
}
