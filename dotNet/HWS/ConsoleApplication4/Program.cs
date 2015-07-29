using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Pick the number for the first side of triangle: ");
            double leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number for 2nd side: ");
            double leg2 = Convert.ToDouble(Console.ReadLine());
            findC2(leg1, leg2);
            Console.ReadLine();
        }
        public static void findC2(double a, double b) {
            Console.WriteLine("Hypotenuse is: "+(Math.Sqrt((a*a)+(b*b))));
        }
    }
}
