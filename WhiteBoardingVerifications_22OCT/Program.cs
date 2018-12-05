using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardingVerifications_22OCT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int [] { 1, 2, 3, 4, 5, 6 };

            //foreach (int a in arr)
            //{
            //    Console.WriteLine("Before Reverse is called:");
            //    Console.WriteLine(a);
            //}
            //arr = Reverse(arr);
            //foreach (int a in arr)
            //{
            //    Console.WriteLine("After Reverse is called:");
            //    Console.WriteLine(a);
            //}
            //string alpha = "aaaabbbbcccc";
            //Console.WriteLine(Compress(alpha));
            //foreach (char a in alpha)
            //{
            //    Console.Write(a);
            //}
            int num = 12321;
            Console.WriteLine(IsPalindrome(num));
             

        }
        public static int [] Reverse(int [] arr)
        {
            int j = 0;
            for (int i = arr.Length -1; i > j; i--)
            {

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                if (j+1 == i || j == i)
                    break;

               
                j++;
            }
            return arr;
        }

        public static string Compress(string alpha)
        {
            int count = 1;

            StringBuilder result = new StringBuilder(alpha.Length);
            for (int i = 0; i < alpha.Length -1; i++)
            {
                if (i + 1 != alpha.Length - 1)
                {
                    if (alpha[i] == alpha[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        result.Append(alpha[i]);
                        result.Append(count);
                        count = 1;
                    }
                }
                
                {
                    result.Append(alpha[i + 1]);
                    result.Append(count);
                }

            }
            if (alpha.Length < result.Length)
                return alpha;
            else
                return result.ToString();
        }
        public static bool IsPalindrome(int num)
        {
            List<int> list = new List<int>();
            int tempNum = num;
            int newNum = 0;
            string length = num.ToString();
            int k = 0;
            while (num < 1000000)
            {
                tempNum = num;
                do
                {
                    list.Add(tempNum % 10);
                    tempNum = tempNum / 10;
                    k++;
                } while (k != length.Length);

                for (int i = 0; i < list.Count; i++)
                {
                    newNum += list[i] * Convert.ToInt32(Math.Pow(10, list.Count - i - 1));
                }
                if (newNum == num)
                    return true;
                else
                    num += newNum;
            }
            return false;






            //int tryPal = newNum + num;
            //string pal = tryPal.ToString();
            //int j = pal.Length - 1;
            //int count = 0;
            //for (int i = 0; i < pal.Length; i++)
            //{
            //    if (pal[i] == pal[j])
            //    {
            //        count++;
            //        j--;
            //    }
            //    if(count == pal.Length)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            


        }
    }
}
