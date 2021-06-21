using System;
using System.Collections.Generic;

namespace Samples1
{
	class Program
	{
		public static  int  Print(List<int> Lista)
        {
            if (Lista.Count == 0)
            {
				return 0;
            }
			else
            {
				Console.WriteLine($"{Lista[0]} {Lista[1]}");
				Lista.RemoveAt(0);
				Lista.RemoveAt(0);
				return Print(Lista);
            }
        }
		static void Main(string[] args)
		{
			List<int> Lista = new List<int> { 10,5,6,9,7,13};
			int numero = 15;
			Print(Lista);
		}

	}
}
