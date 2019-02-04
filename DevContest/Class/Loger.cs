using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevContest
{

	internal class Loger
	{

		public void Info(string message)
		{
			Console.WriteLine($"{DateTime.Now.ToString()} [Info]: {message}.");
		}

		public void Error(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{DateTime.Now.ToString()} [Info]: {message}.");
			Console.ResetColor();
		}

	}

}
