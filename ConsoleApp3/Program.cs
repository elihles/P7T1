using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum, count;
            double average;
            sum = 0;
            count = 0;
            for (int x = 1; x <= 5; x++)
            {
                num = getMark();
                sum += num;

                if (isPass(num))
                {
                    count++;
                }
            }
            average = sum / 5.0;
            Console.WriteLine();
            Console.WriteLine("The sum of the marks      : {0}", sum);
            Console.WriteLine("The average of the marks  : {0}", average);
          
            Console.WriteLine("The number of passes      : {0}", count);
            Console.ReadLine();

        }
        private static int getMark()
        {
            int num;
            do
            {
                Console.Write("Enter a mark: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 100)

                    Console.WriteLine("{0} is not a valid mark, enter a number  between 0 and 100.", num);

            }
            while (num < 0 || num > 100);

            return num;

        }
        private static bool isPass(int num)
        {
            return num >= 50;
        }
    }
}
    

