using System;

namespace CoreNetCondoleApp1
{
    class Program
    {
        static void Main(string[] args)
		{
			new CrossPlatform().Job();
		}
    }

	public class CrossPlatform
	{
		public void Job()
		{
			Console.WriteLine("Hello Cross platform world!");
		}

	}
}
