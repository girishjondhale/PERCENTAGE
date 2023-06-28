using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, Math, Total;

            Console.WriteLine("enter marks of physics");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter marks of chemistry");
            chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter marks of maths");
            Math = Convert.ToInt32(Console.ReadLine());

            Total = phy + chem + Math;
            Console.WriteLine($"Total of sub is {Total}");

            float percentage = Total / 0.3f;
            Console.WriteLine($"percentage is {percentage}");

            if (percentage > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage > 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
        }
    }
}
