using System.Text;

namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3, 4, 5 };
            //int result = FindEquilibrumIndex(arr);
            //Console.WriteLine(CountPairs(arr, 6));

            //int missing = FindMissing(arr, 6);
            //Console.WriteLine(missing);


            //int index = FindRowWithMaximumOnes2D(new int[4, 4] { { 0, 1, 1, 1 }, { 0, 0, 1, 1 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 } });
            //Console.WriteLine(index);

            //List<int> res = FindTriplet(arr, 9);
            //Console.WriteLine(res);

            //Console.WriteLine(string.Join(' ', arr));


            //bool res = IsSubset(new[] { 1,2, 3, 4, 5, 6}, new[] { 1, 2, 4 });
            //Console.WriteLine(res);


            int[] arr2 = SortWave(new[] { 20, 10, 8, 6, 4, 2 });
            Console.WriteLine(string.Join(' ', arr2));
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

                for (int n = arr.Length - 1; n > 0; n--)
                {
                    arr[n] = arr[n - 1];
                  
                }

                arr[0] = lastElement;
            }
        }

        public static int CountPairs(int[] arr, int sum)
        {
            int pairs = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == sum)
                    {
                        pairs++;
                    }
                    
                }
            }

            return pairs;
        }

        public static int FindMissing(int[] arr, int n)
        {
            int[] newArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArr[i] = i + 1;   
            }

            arr = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < n - 1; i++)
            {
                if (newArr[i] != arr[i])
                {
                    return newArr[i];
                }
            }

            return newArr[newArr.Length - 1];
        }

        public static string FindDuplicates(int[] arr, int n)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<int, int> result = new Dictionary<int, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (result.ContainsKey(arr[i]) == false)
                {
                    result.Add(arr[i], 0);
                }

                result[arr[i]]++;
            }

            foreach(var key in result.Keys)
            {
                if (result[key] > 1)
                {
                    sb.Append($"{key}, ");
                }
            }


            return sb.ToString().TrimEnd();
        }

        public static int FindFirstRepeating(int[] arr) 
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach(var number in arr)
            {
                if (numbers.ContainsKey(number) == false)
                {
                    numbers.Add(number, 0);
                }
                else
                {
                    return number;
                }
            }

            return -1;
        }

        public static int CountSubArraysWithEqual0And1(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result = new Dictionary<int, int>();
                result.Add(arr[i], 1);

                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (result.ContainsKey(arr[k]) == false)
                    {
                        result.Add(arr[k], 1);
                    }
                    else
                    {
                        result[arr[k]]++;
                    }

                    if (result.ContainsKey(0) && result.ContainsKey(1) && result[0] == result[1])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int LongestConsecutiveSubsequence(int[] arr)
        {
            int length = 1;
            int maxLength = 0;

            List<int> result = new List<int>();
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    result.Add(arr[i]);
                }   
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    length++;
                }
                else
                {
                    length = 0;
                }

                if(maxLength < length)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }

        public static int MaxSumInConfiguration(int[] arr)
        {
            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;

                for (int k = 0; k < arr.Length; k++)
                {
                    currentSum += arr[k] * k;
                }

                if(maxSum < currentSum)
                {
                    maxSum = currentSum;
                }

                int lastElement = arr[arr.Length - 1];

                for (int k = arr.Length - 1; k > 0; k--)
                {
                    arr[k] = arr[k - 1];   
                }

                arr[0] = lastElement;
            }

            return maxSum;
        }

        public static int MinJumps(int[] arr)
        {
            int i = 0;
            int count = 0;
           
            while(i < arr.Length)
            {
                int step = arr[i];
                i += step;

                if (i < arr.Length)
                {
                    count++;
                }  
            }

            return count;
        }

        public static List<int>? FindTriplet(int[] arr, int sum)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == sum)
                        {
                            indexes.Add(arr[i]);
                            indexes.Add(arr[j]);
                            indexes.Add(arr[k]);

                            return indexes;
                        }
                    }
                }
            }

            return null; 

        }

        public static int FindRowWithMaximumOnes2D(int[,] matrix)
        {
            int maxOnes = 0;
            int rowIndex = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int countOnes = 0;

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] == 1)
                    {
                        countOnes++;
                    }   
                }

                if(maxOnes < countOnes)
                {
                    maxOnes = countOnes;
                    rowIndex = i;
                }
            }

            return rowIndex;
        }

        public static bool IsSubset(int[] arr1, int[] arr2)
        {
            int k = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (k = 0;  k < arr1.Length;  k++)
                {
                    if (arr2[i] == arr1[k])
                    {
                        break;
                    }
                }

                if(k == arr1.Length)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] SortWave(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(i % 2 == 0)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        Swap(arr, i, i + 1);   
                    }
                }
                else
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                    }
                }
                
            }

            return arr;

        }


        public static void Swap(int[] arr, int i, int k)
        {
            int temp = arr[i];
            arr[i] = arr[k];
            arr[k] = temp;
        }


    
      
    }
}

