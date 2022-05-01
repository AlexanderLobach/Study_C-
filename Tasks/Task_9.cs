using System;
using System.Linq;
public class Task_9
{
    public static int Sum(int num)
    {
        int sum = 0;
        for(int i = num; i > 0; i--)
        {
            sum += i;
        }
        Console.WriteLine("Task_9 result: {0}", sum);
        return sum;
    }
}
