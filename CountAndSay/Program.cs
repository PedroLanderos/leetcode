using System.Text;

namespace CountAndSay;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public string CountAndSay(int n)
    {
        //base case
        if (n == 1) return "1";

        string prev = CountAndSay(n - 1);

        StringBuilder result = new StringBuilder();

        /*
         Input: n = 4

        Output: "1211"

        Explanation:

        countAndSay(1) = "1"
        countAndSay(2) = RLE of "1" = "11"
        countAndSay(3) = RLE of "11" = "21"
        countAndSay(4) = RLE of "21" = "1211"
          
         */

        //the base case guarantees a lenght 1
        int count = 1;

        //counts the total elements of the same type
        for(int i = 1; i < prev.Length; i++)
        {
            //counts how many numbers are being reference
            if (prev[i] == prev[i - 1])
            {
                count++;
            }
            else
            { 
                //starts a new count of a different group of numbers
                result.Append(count);
                result.Append(prev[prev.Length - 1]);
                count = 1;
            }

        }

        //adds the count value at the beggining of the string 
        result.Append(count); // -> 1 
        //adds the value that count is referencing 
        result.Append(prev[prev.Length - 1]);


        return result.ToString();
    }
}
