using System;

public class Converter
{
    public static string dnaToRna(string str)
    {
        Console.WriteLine(str.Length);
        char[] char_arr;
        char_arr = str.ToCharArray();
        int i = 0;
        foreach (var item in char_arr)
        {
            if (item == 'U')
            {
                char_arr[i] = 'T';
            }
            i++;
        }
       // str = new string(char_arr);
       // Console.WriteLine(str.Length);
       str = str.Replace('U','T'); //замена символа в строке
        return str;
    }
}
