using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Homework;

namespace TDD_Tests
{
    [TestClass]
    public class TestUppercaseFirstEach
    {
        [TestMethod]
        public void Test__Uppercase_Each_Word()
        {
            string[] input  = {"sju", "sjösjuka", "sjömän"};
            string expected = "Sju Sjösjuka Sjömän";

            string result = StringUtils.UppercaseFirstEach(input);

            Assert.AreEqual(expected, result);
        }

    }
}