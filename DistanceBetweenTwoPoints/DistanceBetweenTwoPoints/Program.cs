using System;

namespace DistanceBetweenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance.WriteTitle();

            Distance.SetPoints();

            Distance.CalcDistanc();

            Console.ReadKey();
        }
    }
}
