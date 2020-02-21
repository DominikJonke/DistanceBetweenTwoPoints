using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPoints
{
    public static class Distance
    {
        public static double x1 = 0;
        public static double y1 = 0;
        public static double x2 = 0;
        public static double y2 = 0;

        public static void WriteTitle()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t Distance Calculator");
            Console.WriteLine();
        }

        public static void SetPoints()
        {
            Console.Write("\tWhere is the first x point: \t");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tWhere is the first y point: \t");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tWhere is the second x point: \t");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tWhere is the second y point: \t");
            y2 = Convert.ToInt32(Console.ReadLine());
        }

        public static void CalcDistanc()
        {            
            double distance = 0;

            distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine($"\n\t\tDistance: \t\t{Math.Round(distance, 2)}");
        }
    }
}
