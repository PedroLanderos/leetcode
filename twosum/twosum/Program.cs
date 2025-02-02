// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> arrayNumbers = new Dictionary<int, int>();

    
    for(int i = 0; i < nums.Length; i++)
    {
        //revisar si el target - menos el elemento actual en el array existe en el map
        if (arrayNumbers.ContainsKey(target - nums[i]))
        {
            //si no existe se agrega al map
            return new int[] { arrayNumbers[(target - nums[i])], i };
        }

        arrayNumbers[nums[i]] = i;

    }

    return new int[] { -1, -1 };

}