using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter phone number: ");
            String number = Console.ReadLine();
            String sub = number.Substring(0, 3);
            if((sub != "703") && (sub != "571")) {
                Console.WriteLine("Not a local number");
            }
            else {
                Console.WriteLine("Local number");
            }

            Console.ReadLine();
        }
    }
}
