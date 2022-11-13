using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int>numbers=Enumerable.Range(1,10);
			foreach (int item in numbers)
			{
				Console.Write(item+"\r\n");
			}
			Console.WriteLine("結束");
			IEnumerable<int> numbers1 = Enumerable.Range(10, 6);
			foreach (int item1 in numbers1)
			{
				Console.Write(item1+"\r\n");
			}
		}
	}
}
