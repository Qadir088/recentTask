using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 250, 23, 457, 456, 321, 875, 246, 190, 234, 800, 9837, 12351 };
            Console.WriteLine("Enter min : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max : ");
            int max = Convert.ToInt32(Console.ReadLine());
            foreach(var value in array)
            {
                int sum = 0;
                if (value > min && value < max)
                {
                    int temp = value;
                    while (temp > 0)
                    {
                        int lastNum = temp % 10;
                        sum += lastNum;
                        temp = temp / 10;
                    }
                    if (sum > 7)
                    {
                        Console.WriteLine(value);
                        Console.WriteLine(sum);
                    }
                }
            }
        }
    }
}
