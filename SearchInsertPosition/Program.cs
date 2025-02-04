using System.Formats.Tar;

namespace SearchInsertPosition;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int SearchInsert(int[] nums, int target)
    {
        //You must write an algorithm with O(log n) runtime complexity.

        //input: nums = [1,3,5,6], target = 5
        //Output: 2
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    int BinarySearch(int[] nums, int target, int left, int right)
    {
        //only one element
        if (left > right) return left;

        //get the mid of the array (ex, 1, 2, 3, 4, 5), left = 0, right = 4. mid = 0 + ((4 - 0) / 2) == 2
        int mid = left + (right - left) / 2;

        //base case
        if (nums[mid] == target) 
            return mid;
        else if (nums[mid] < target) //search on the right half
            return BinarySearch(nums, target, mid + 1, right);
        else return BinarySearch(nums, target, left, mid - 1); //search on the left half
    }
}