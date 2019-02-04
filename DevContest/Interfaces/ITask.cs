namespace DevContest
{

	public interface ITask<TInput, TResult>
	{

		TResult Exe(TInput input, int method = 1);

	}

}
