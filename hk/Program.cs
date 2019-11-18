using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hk
{
    class Program
    {
        public string CompressWord(string s, int k)
        {
            int x;
            char[] a = s.ToCharArray();
            string b = "";
            int i = 0;

            while (i < a.Length)
            {
                x = 0;
                int j = i;

                if (a[i] == a[j])
                {
                    x += 1;
                    for (j = j + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            x += 1;

                        }
                        else
                        {
                            break;
                        }
                    }
                    if (k != x)
                    {
                        b += a[i];
                        i = i + 1;
                    }
                    else
                    {
                        i = i + 2;
                    }




                }


            }

            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Number of consecutive charcaters to be removed");
            int k = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            string s1 = p.CompressWord(s, k);
            //string s2 ="";



            do
            {
                s = p.CompressWord(s, k);
            } while (s.Distinct().Count() >= 2);

            Console.WriteLine(s);
        }
    }
}

