using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace hk
{
    class carparking
    {
        static void Main1(string[] args)
        {
            int n;
           
            
          //  Console.WriteLine("Enter the  size of parking space to park");
            n = ToInt32(ReadLine());
            int[] arr = new int[n];
           // Console.WriteLine("enter the slots of parking");
            carparking car = new carparking();
            int f = car.Carparkingcover(arr, n);
            Console.WriteLine(f);

        }
        
        public int Carparkingcover(int[] arr,int n)
       {
            //int temp = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = ToInt32(ReadLine());
            }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            Array.Sort(arr);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            int k;
            //Console.WriteLine("enter the number of cars to be covered");
            k = ToInt32(ReadLine());
            int l;
            l = arr[k - 1] - arr[0];
            //Console.WriteLine(l + 1);
            return l + 1;
        }
       
    }
}
