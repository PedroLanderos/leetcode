string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

    //obtener el tamano mas pequeno
    int l = int.MaxValue;
    foreach(var s in strs)
    {
        if(s.Length < l)
            l = s.Length;
    }

    //recorrer los strings hasta la cadena mas pequena
    for(int i = 0; i < l; i++)
    {
        char currentChar = strs[0][i];
        foreach (var s in strs)
        {
            if (s[i] != currentChar)
                return s.Substring(0, i);
        }

    }
    return strs[0].Substring(0, l);
}
