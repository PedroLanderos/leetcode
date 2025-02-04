namespace removeDuplicates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public int RemoveDuplicates(int[] nums)
    {
        //hash to save unique numbers
        HashSet<int> n = new HashSet<int>();

        int i = 0;

        foreach(var x in nums)
        {
            if (n.Add(x)) //saving the numbers in the hash
            {
                //modifying the nums array by adding the unique element
                nums[i] = x; 
                i++;
            }
        }

        return i;
    }
}
