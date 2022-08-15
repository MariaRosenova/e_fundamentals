using System;
using System.Linq;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Read the input
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultNums = new List<int>();
            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
                //TODO: Add numbers in resultNums
                if (nums1.Count > nums2.Count)
                    resultNums.AddRange(GetRemainingElements(nums1, nums2));
                else if (nums2.Count > nums1.Count)
                    resultNums.AddRange(GetRemainingElements(nums2, nums1));
            Console.WriteLine(string.Join(" ", resultNums));

        }
        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
                nums.Add(longerList[i]);
            return nums;
        }




    }
}

