namespace DevContest.Tasks1_50
{

	/// <summary>
	/// A + B
	/// <see cref="http://acmp.ru/index.asp?main=task&id_task=1" />
	/// </summary>
	public class Task1 : ITask<Task1_Input, Task1_Result>
	{

		public Task1_Result Exe(Task1_Input input, int method = 1)
		{
			if (!input.IsValid())
				throw new NotValidInputException();

			return new Task1_Result(input.A + input.B);
		}

	}

	/// <summary>
	/// Input
	/// </summary>
	public class Task1_Input : IValidator
	{

		public uint A { get; set; }

		public uint B { get; set; }

		protected Task1_Input(uint a, uint b)
		{
			this.A = a;
			this.B = b;
		}

		public static Task1_Input Create(uint a, uint b) => new Task1_Input(a, b);

		public bool IsValid()
		{
			return true;
		}

	}

	/// <summary>
	/// Result
	/// </summary>
	public class Task1_Result
	{

		public uint Result { get; set; }

		public Task1_Result(uint result)
		{
			this.Result = result;
		}

	}

}
