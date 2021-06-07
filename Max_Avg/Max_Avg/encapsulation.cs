using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

	public class Source
	{
		public int Add(int a, int b, int c)
		{
			return a + b + c;
		}
		public double Add(double a, double b, double c)
		{
			return a + b + c;
		}
		public static void Main(string[] args)
		{
			Source s = new Source();
			int res = s.Add(2, 3, 4);
			Console.WriteLine(res);
			double res1 = s.Add(2.5, 4.5, 6.3);
			Console.WriteLine(res1);
		}
	}


