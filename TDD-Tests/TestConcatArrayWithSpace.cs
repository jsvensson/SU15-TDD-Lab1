using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Homework;

namespace TDD_Tests
{
	[TestClass]
	public class TestConcatArrayWithSpace
	{
		[TestMethod]
		public void Test__Concatenates_String_Array()
		{
			string[] input = {"Sju", "sjösjuka", "sjömän"};
			string expected = "Sju sjösjuka sjömän";

			string result = StringUtils.ConcatArrayWithSpace(input);

			Assert.AreEqual(expected, result);
		}
	}
}
