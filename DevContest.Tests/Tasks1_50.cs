using DevContest.Tasks1_50;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevContest.Tests
{

	[TestClass]
	public class Tasks1_50
	{

		#region Task #00001

		[TestMethod]
		[TestCategory("Задачи для начинающих")]
		public void TestTask1()
		{
			var t1 = Task1_Input.Create(2, 2);
			Assert.AreEqual(new Task1().Exe(t1).Result, 4u);

			var t2 = Task1_Input.Create(1, 5);
			Assert.AreEqual(new Task1().Exe(t2).Result, 6u);

			var t3 = Task1_Input.Create(0, 1000);
			Assert.AreEqual(new Task1().Exe(t3).Result, 1000u);

			var t4 = Task1_Input.Create(10, 10);
			Assert.AreEqual(new Task1().Exe(t4).Result, 20u);

			var t5 = Task1_Input.Create(123, 456);
			Assert.AreEqual(new Task1().Exe(t5).Result, 579u);
		}

		#endregion

		#region Task #00002

		[TestMethod]
		[TestCategory("Целочисленная арифметика")]
		public void TestTask2()
		{
			var t1 = Task2_Input.Create(5);
			Assert.AreEqual(new Task2().Exe(t1).Result, 15u);

			var t2 = Task2_Input.Create(100);
			Assert.AreEqual(new Task2().Exe(t2).Result, 5050u);

			var t3 = Task2_Input.Create(16);
			Assert.AreEqual(new Task2().Exe(t3).Result, 136u);

			var t4 = Task2_Input.Create(1);
			Assert.AreEqual(new Task2().Exe(t4).Result, 1u);

			var t5 = Task2_Input.Create(2);
			Assert.AreEqual(new Task2().Exe(t5).Result, 3u);
		}

		#endregion

		#region Task #00003

		[TestMethod]
		[TestCategory("Целочисленная арифметика")]
		public void TestTask3()
		{
			var t1 = Task3_Input.Create(5);
			Assert.AreEqual(new Task3().Exe(t1).Result, 25u);

			var t2 = Task3_Input.Create(75);
			Assert.AreEqual(new Task3().Exe(t2).Result, 5625u);

			var t3 = Task3_Input.Create(4255);
			Assert.AreEqual(new Task3().Exe(t3).Result, 18105025u);
		}

		#endregion

	}

}
