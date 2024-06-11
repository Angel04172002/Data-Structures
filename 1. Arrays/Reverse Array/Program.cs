namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 3, 5, 7, 9 };
            //int result = FindEquilibrumIndex(arr);
            RotateArray(arr, 2);

            Console.WriteLine(string.Join(' ', arr));
        }

        public static int LargestSumSubarray(int[] arr)
        {
            List<int> result = new List<int>();

            int maxSum = 0;
            int currentSum = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = currentSum + arr[i];

                if(maxSum < currentSum)
                {
                    maxSum = currentSum;
                }

                if(currentSum < 0)
                {
                    currentSum = 0;
                }

            }


            return maxSum;
        }

        public static int FindMaxProduct(int[] arr)
        {
            int maxProduct = 0;
            int currentProduct = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentProduct = arr[i];

                for (int k = i + 1; k < arr.Length; k++)
                {
                    currentProduct *= arr[k];
                    currentProduct = Math.Abs(currentProduct);

                    if (maxProduct < currentProduct)
                    {
                        maxProduct = currentProduct;
                    }

                }

            }

            if (maxProduct < currentProduct)
            {
                maxProduct = currentProduct;
            }

            return maxProduct;
        }

        public static int FindEquilibrumIndex(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int previousSum = 0;
                int nextSum = 0;

                for (int k = 0; k < i; k++)
                {
                    previousSum += arr[k];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    nextSum += arr[k];
                }

                if(previousSum == nextSum)
                {
                    return i;
                }

            }

            return -1;

        }

        public static void RotateArray(int[] arr, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int lastElement = arr[arr.Length - 1];

                for (int n = arr.Length -1; n > 0; n--)
                {
                    arr[n] = arr[n - 1];
                  
                }

                arr[0] = lastElement;
            }
        }
    }
}
