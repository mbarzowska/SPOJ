// http://www.spoj.com/problems/SMPSUM/ 
using System;

namespace SMPSUM {
    class SMPSUM {
        public static void Main(string[] args) {
            string[] input = Console.ReadLine().Split();
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
			int sum = 0;
			for (int i = a; i <= b; i++) {
				sum += i*i;
			}
			Console.WriteLine(sum);
        }
    }
}