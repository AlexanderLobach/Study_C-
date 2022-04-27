using System;

public class Converter
{
    public static string dnaToRna(string str)
    {
        char[] char_arr;
        char_arr = str.ToCharArray();
        int i = 0;
        foreach (var item in char_arr)
        {
            if (item == 'U')
            {
                char_arr[i] = 'T';
                i++;
            }
        }
        str = Convert.ToString(str);
        return str;
    }
}
