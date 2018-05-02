// http://www.spoj.com/problems/ADDREV/ 
using System;

namespace ADDREV {
    class ADDREV {
        public static int reverse(int value) {
            int result = 0;
            while (value > 0) {
                result = result * 10;
                result = result + (value % 10);
                value = value / 10;
            }
            return result;
        }

        public static void Main(string[] args) {
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lines; i++) {
                string[] numbers = Console.ReadLine().Split();
                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);
                Console.WriteLine(reverse(reverse(num1) + reverse(num2)));
            }
        }
    }
}