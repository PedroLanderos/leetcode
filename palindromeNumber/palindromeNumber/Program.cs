Console.WriteLine(IsPalindrome(121));
bool IsPalindrome(int x)
{
    if(x < 0) return false;

    string str = x.ToString();
    string rev = new string(str.Reverse().ToArray());

    return str == rev;

}