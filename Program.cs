using System.Numerics;

namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    if (int.TryParse(arg, out var value))
                    {
                        Console.WriteLine($"The sum of the digits of the number {value} is : {SumDigits(value)}");
                    }
                }
            }
        }

        static int SumDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
