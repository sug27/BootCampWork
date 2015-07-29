using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 {
    class Program {
        static void Main(string[] args) {
            int[] numbers;
            Console.WriteLine("Please enter the length of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            numbers = new int[len];
            fillArray(ref numbers);
            
            Console.ReadLine();
        }
        public static void fillArray(ref int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Enter " + (i + 1) + "th number");
                int entry = Convert.ToInt32(Console.ReadLine());
                array[i] = entry;
            }
            int total = 0;
            for (int j = 0; j < array.Length; j++) {
                Console.WriteLine(array[j]);
                total += array[j];
            }
                Console.WriteLine("Average is "+total/array.Length);
            } 
        }
       
    }
    

