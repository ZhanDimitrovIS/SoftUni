using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());         
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    count2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    count3++;
                }
                else if (number >=600 && number <= 799)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;
                }

            }
            double sumNum = n;
            double p1 = count1 / sumNum * 100;
            double p2 = count2 / sumNum * 100;
            double p3 = count3 / sumNum * 100;
            double p4 = count4 / sumNum * 100;
            double p5 = count5 / sumNum * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");




        }
    }
}
