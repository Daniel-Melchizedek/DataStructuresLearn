namespace Arrays_2_MoveAllZeroesToEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 0, 4, 3, 0, 5, 0];
            MoveZeroesToEnd(arr);
            Console.WriteLine(string.Join(",",arr));
        }
        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="arr"></param>
        public static void MoveZeroesToEnd(int[] arr)
        {
            for(int i=0,count =0; i<arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Swap(arr, i, count);
                    count++;
                }
            }
        }
        public static void Swap(int[] arr, int i, int count)
        {
            int temp = arr[i];
            arr[i] = arr[count];
            arr[count] = temp;
        }

    }
}
