using System;

public class Task_8
{
    public static string Solution(string str)
    {
        char[] temp = new char[str.Length];
        int x = str.Length-1;
        foreach (var item in str)
        {
            temp[x] = item;
            x--;
        }
        str = String.Concat(temp);
        Console.WriteLine("Task_8 result: {0}", str);
        return str;
    }
}
