using System;
using System.Collections.Generic;

namespace InterviewPractice
{
    /*
     * The problem is to find the subarray with the largest sum. Solution here is found in O(n), though there is some extra overhead
     * to print it out. Could be reduced by adding subarrays or elements to a list.
     */
    class maxSubArray
    {

        public static void MaxSubArray(int[] arr) {
            List<int> indexOnes = new List<int>();
            int currentMax, totalMax, index1, oldTotalMax, index2, indexIndex;
            indexIndex = 0;
            currentMax = totalMax = arr[0];
            index1 = index2 = 0;
            if (arr.Length == 1) {
                Console.WriteLine("Subarray with largest sum is {" + arr[0] + "} with sum " + totalMax);
                return;
            }
            for (int i = 1; i < arr.Length; i++) {
                
                oldTotalMax = totalMax;
                currentMax = Math.Max(arr[i], currentMax + arr[i]);
                totalMax = Math.Max(totalMax, currentMax);

                if (currentMax == arr[i]) {
                    index1 = i;
                }

				if (oldTotalMax != totalMax)
				{
					index2 = i;
					indexIndex = index1;
				}

            }

            Console.WriteLine($"Max sum is {totalMax}.");
            Console.WriteLine($"The subarray is from {indexIndex} to {index2}");
            int[] sub = new int[index2 - indexIndex + 1];
            Array.Copy(arr,indexIndex,sub,0, index2-indexIndex + 1);
            Console.Write("Elements: ");
            foreach (int i in sub) {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] firstTest = { 9 };
            MaxSubArray(firstTest);
            int[] secondTest = { -2, 1, -3, 4, -1, 2, 1, -5, 4, 5 };
            MaxSubArray(secondTest);
            int[] thirdTest = { -2, -1, 10 };
            MaxSubArray(thirdTest);
        }
    }
}
