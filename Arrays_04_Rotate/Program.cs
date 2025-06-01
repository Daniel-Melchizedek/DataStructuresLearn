using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Arrays_04_Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 3;
            int[] arr = [9, 18, 27, 36, 45];
            //RotateArray_NaiveApproach(arr, d);
            //RotateArray_BetterApproach(arr,d);
            //RotateArray_JugglingAlgo(arr, d);
            RotateArray_ReverseAlgo(arr, d);
            Console.WriteLine($"{string.Join(",", arr)}");
        }

        // Time complexity: O(n*d)
        // Space O(1)
        static void RotateArray_NaiveApproach(ref int[] arr, int d)
        {
            if (arr.Length <= 1)
                return;
            d = d % arr.Length;

            for (int i = 0; i < d; i++)
            {
                int first = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }

                arr[arr.Length - 1] = first;
            }
        }
        
        // Time complexity: O(n) 2x iteration
        // Space complexity:O(n)
        static void RotateArray_BetterApproach(int[] arr, int d)
        {
            if (arr.Length <=1)
                return;
            d %= arr.Length;
            if (d == 0)
                return;

            int[] temp = new int[arr.Length];

            int j = 0;
            for(int i = d; i < arr.Length; i++,j++)
            {
                temp[j] = arr[i];
            }

            for(int i = 0; i<d;i++,j++)
            {
                temp[j] = arr[i];
            }
            Array.Copy(temp,arr,arr.Length);
            return;
        }
        
        //Time Complexity:O(n)
        //Space Complexity: O(1)
        static void RotateArray_JugglingAlgo(int[] arr, int d)
        {
            if(arr.Length<=1)
                return;

            d %= arr.Length;

            if (d == 0)
            {
                return;
            }
            int cycles = GCD(arr.Length,d);

            for(int i=0;i<cycles; i++)
            {
                int firstElement = arr[i];
                int currentIndex = i;
                while (true)
                {
                    int nextIndex = (currentIndex + d) % arr.Length;

                    if (nextIndex == i)
                    {
                        break;
                    }

                    arr[currentIndex] = arr[nextIndex];
                    currentIndex = nextIndex;
                }
                arr[currentIndex] = firstElement;
            }

        }

        static void RotateArray_ReverseAlgo(int[] arr, int d)
        {
            d%=arr.Length;
            if(d ==0 || arr.Length<=1)
                return;
            Reverse(arr, 0, d - 1);
            Reverse(arr,d, arr.Length - 1);
            Reverse(arr, 0, arr.Length - 1);
            
        }
        static void Reverse(int[] arr,int startIndex,int endIndex)
        {
            while(startIndex<endIndex)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
        static int GCD(int a, int b)
        {
            while(b !=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }



    }
}
