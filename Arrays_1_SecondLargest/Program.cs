namespace Arrays_1_SecondLargest_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = [3,2,2];
            Array.Reverse(input);
            int result = GetSecondLargest(input);
            Console.WriteLine(result);
        }

        /// <summary>  
        /// Time Complexity: O(n)  
        /// Space Complexity: O(1)  
        /// </summary>  
        public static int GetSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                return -1;
            }

            int largest, secondLargest;
            largest = secondLargest = -1;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if(num>secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            return secondLargest;
        }
    }
}
