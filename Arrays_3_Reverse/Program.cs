namespace Arrays_3_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 4, 3, 2, 6, 5];
            ReverseArray_LeftAndRight(arr);
            Console.WriteLine(string.Join(",", arr));

        }

        static void ReverseArray_InBuilt(int[] arr)
        {
            Array.Reverse(arr);
        }
        static void ReverseArray_HalfTraversal(int[] arr)
        {
            for(int i=0,j=arr.Length-1; i<arr.Length/2;i++,j--)
            {
                Swap(arr, i, j);
            }
        }

        static void ReverseArray_LeftAndRight(int[] arr) 
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left<right)
            {
                Swap(arr, left, right);
                left++;
                right--;
            }
        }
        static void Swap(int[] arr,int left,int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

    }
}
