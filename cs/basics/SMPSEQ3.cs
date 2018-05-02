// http://www.spoj.com/problems/SMPSEQ3/ 
using System;
using System.Collections.Generic;
using System.Linq;

namespace SMPSEQ3 {
    class SMPSEQ3 {
        public static void Main(string[] args) {
        	Console.ReadLine();
            string[] firstLine = Console.ReadLine().Split();
            Console.ReadLine();
            string[] secondLine = Console.ReadLine().Split();
            List<string> outputList =  new List<string>();
            foreach(string i in firstLine) {
            	if (!secondLine.Any(b => b == i)) {
            		outputList.Add(i);
            	}
            }
            string[] output = outputList.ToArray();
			Console.WriteLine(string.Join(" ", output));
        }
    }
}