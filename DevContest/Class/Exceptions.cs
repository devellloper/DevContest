using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevContest
{

	public class NotValidInputException : Exception
	{

		public NotValidInputException() : base("Input data is not valid.")
		{
		}

	}

}
