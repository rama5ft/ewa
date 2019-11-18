using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace hk
{
    class OscillatingString
    {
        static void Main1(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string");
            str = ReadLine();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            char[] c1 = new char[str.Length];
            char[] c2 = new char[str.Length];
            int j = 0;
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!c1.Contains(ch[i]))
                {
                    c1[j] = ch[i];
                    j++;
                }
                else
                {
                    c2[k] = ch[i];
                    k++;
                }
            }
            char[] c3 = new char[j];
            char[] c6 = new char[k];

            for (int i = 0; i < j; i++)
            {
                c3[i] = c1[i];
            }
            for (int i = 0; i < k; i++)
            {
                c6[i] = c2[i];
            }
                Array.Sort(c3);
                Array.Sort(c6);
                Array.Reverse(c6);


            string c5="";
            string c4="";

            for (int i = 0; i < c3.Length; i++)
            {
                c5+= c3[i];
              
            }

            for (int i = 0; i < c6.Length; i++)
            {
                c4+= c6[i];
               
            }
            string ss = c5 + c4;
            Console.WriteLine(ss);

        }
    }
    }

