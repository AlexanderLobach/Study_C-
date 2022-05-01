using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Hello Константин!\nenter number:");
            int num = Task_1.StringToNumber(Console.ReadLine());
            Console.WriteLine("The number = {0}",num);
            // Task_2
            int sheeps = Task_2.CountSheeps(Task_2.Sheeps);
            Console.WriteLine("Sheeps = {0}", sheeps);
            result = Converter.dnaToRna("UfHUNNKNUUUU");
            Console.WriteLine(result);
            Task_4.Opposite(12);
            Task_5.MakeToUpper("branch");
            Task_6.Liters(1.0);
            Task_7.TotalPoints(new[]{"1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" });
        }
    }
}
