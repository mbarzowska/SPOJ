// http://www.spoj.com/problems/EXPECT/
using System;

namespace EXPECT {
    class EXPECT {
        static void Main(string[] args) {
            int n;
            while (true) {
				n = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(n);
				Console.Clear();
				if (n == 42) break;
            }
        }
    }
}
