
using System.Diagnostics;
using System.Reflection;

int Reverse(int x)
{

    bool isNegative = x < 0;

    long n = Math.Abs((long)x);

    string reverseString = new string(n.ToString().Reverse().ToArray()).TrimEnd('0');

    long reverse = reverseString == "" ? 0 : long.Parse(reverseString);

    if (isNegative) reverse *= -1;

    if (reverse < int.MinValue || reverse > int.MaxValue) return 0;

    return (int)reverse;

}