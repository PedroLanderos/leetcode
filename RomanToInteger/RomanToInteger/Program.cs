int RomanToInt(string s)
{
    Dictionary<char, int> romanNumbers = new Dictionary<char, int>() {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int total = 0;
    int prevValue = 0;
    //III
    //IV
    //recorrer de derecha a izquierda la cadena 
    for (int i = s.Length - 1; i >= 0; i--)
    {
        int currentValue = romanNumbers[s[i]]; // V -> 5

        if (currentValue < prevValue)
            total -= currentValue;
        else total += currentValue;

        prevValue = currentValue;
    }

    return total;
}