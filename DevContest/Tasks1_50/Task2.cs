namespace DevContest.Tasks1_50
{

	/// <summary>
	/// Сумма
	/// <see cref="http://acmp.ru/index.asp?main=task&id_task=2" />
	/// </summary>
	public class Task2 : ITask<Task2_Input, Task2_Result>
	{

		public Task2_Result Exe(Task2_Input input, int method = 1)
		{
			if (!input.IsValid())
				throw new NotValidInputException();

			uint result = 0;
			for (uint i = 1; i <= input.N; i++)
				result += i;

			return new Task2_Result(result);
		}

	}

	/// <summary>
	/// Input
	/// </summary>
	public class Task2_Input : IValidator
	{

		public uint N { get; set; }

		protected Task2_Input(uint n)
		{
			this.N = n;
		}

		public static Task2_Input Create(uint n) => new Task2_Input(n);

		public bool IsValid()
		{
			if (this.N == 0)
				return false;

			return true;
		}

	}

	/// <summary>
	/// Result
	/// </summary>
	public class Task2_Result
	{

		public uint Result { get; set; }

		public Task2_Result(uint result)
		{
			this.Result = result;
		}

	}

}
