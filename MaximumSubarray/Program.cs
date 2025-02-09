namespace MaximumSubarray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int MaxSubArray(int[] nums)
    {
        //Given an integer array nums, find the  subarray with the largest sum, and return its sum.

        /*
         Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: The subarray [4,-1,2,1] has the largest sum 6.
         */

        //nums[0] allows the algorithm to do a valid comparison
        int currentSum = nums[0];
        int maxSum = nums[0];

        for(int i = 1; i < nums.Length; i++)
        {
            //find the maximum between currentSum and the i element of the array
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
