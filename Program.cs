using System;

namespace PracticleFloatingPoints
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var floating1 = decimal.Parse(Console.ReadLine());
			var floating2 = double.Parse(Console.ReadLine());
			var floating3 = decimal.Parse(Console.ReadLine());

			Console.WriteLine("{0} \n {1} \n {2}", floating1, floating2, floating3);
		}
	}
}
