using System;

namespace DevContest.Tasks1_50
{

	/// <summary>
	/// Игра
	/// <see cref="http://acmp.ru/index.asp?main=task&id_task=4" />
	/// </summary>
	public class Task4 : ITask<Task4_Input, Task4_Result>
	{

		public Task4_Result Exe(Task4_Input input, int method = 1)
		{
			if (!input.IsValid())
				throw new NotValidInputException();

			switch (method)
			{
				default:
				case 1:
					return Method1(input);
				case 2:
					return Method2(input);
			}
		}

		private Task4_Result Method1(Task4_Input input)
		{
			uint result;
			switch (input.N)
			{
				default:
				case 1:
					result = 198;
					break;
				case 2:
					result = 297;
					break;
				case 3:
					result = 396;
					break;
				case 4:
					result = 495;
					break;
				case 5:
					result = 594;
					break;
				case 6:
					result = 693;
					break;
				case 7:
					result = 792;
					break;
				case 8:
					result = 891;
					break;
				case 9:
					result = 990;
					break;
			}
			return new Task4_Result(result);
		}

		private Task4_Result Method2(Task4_Input input)
		{
			uint right = 9 - input.N;
			uint result = Convert.ToUInt32(input.N.ToString() + "9" + right);
			return new Task4_Result(result);
		}

	}

	/// <summary>
	/// Input
	/// </summary>
	public class Task4_Input : IValidator
	{

		public uint N { get; set; }

		protected Task4_Input(uint n)
		{
			this.N = n;
		}

		public static Task4_Input Create(uint n) => new Task4_Input(n);

		public bool IsValid()
		{
			if (this.N < 1 || this.N > 9)
				return false;

			return true;
		}

	}

	/// <summary>
	/// Result
	/// </summary>
	public class Task4_Result
	{

		public uint Result { get; set; }

		public Task4_Result(uint result)
		{
			this.Result = result;
		}

	}

}
