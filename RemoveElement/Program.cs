namespace RemoveElement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        //[3,2,2,3
        //3 <- val


        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
