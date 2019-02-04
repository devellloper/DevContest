using System;

namespace DevContest.Tasks1_50
{

	/// <summary>
	/// Пятью пять - двадцать пять!
	/// <see cref="http://acmp.ru/index.asp?main=task&id_task=3" />
	/// </summary>
	public class Task3 : ITask<Task3_Input, Task3_Result>
	{

		public Task3_Result Exe(Task3_Input input, int method = 1)
		{
			if (!input.IsValid())
				throw new NotValidInputException();

			uint result;
			string str = input.N.ToString();
			if (str.Length > 1)
			{
				string left = str.Substring(0, str.Length - 1);
				string right = "25";
				uint a = Convert.ToUInt32(left);
				result = a * (a + 1);
				result = Convert.ToUInt32(result.ToString() + right);
			}
			else
				result = (uint)Math.Pow(Convert.ToInt32(input.N), 2);

			return new Task3_Result(result);
		}

	}

	/// <summary>
	/// Input
	/// </summary>
	public class Task3_Input : IValidator
	{

		public uint N { get; set; }

		protected Task3_Input(uint n)
		{
			this.N = n;
		}

		public static Task3_Input Create(uint n) => new Task3_Input(n);

		public bool IsValid()
		{
			if (!this.N.ToString().EndsWith("5"))
				return false;

			return true;
		}

	}

	/// <summary>
	/// Result
	/// </summary>
	public class Task3_Result
	{

		public uint Result { get; set; }

		public Task3_Result(uint result)
		{
			this.Result = result;
		}

	}

}
