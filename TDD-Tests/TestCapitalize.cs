using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Homework;

namespace TDD_Tests
{
    [TestClass]
    public class TestCapitalize
    {
        [TestMethod]
        public void Test__Capitalizes_Words__Removes_Spaces()
        {
            string input    = "sju sjösjuka sjömän";
            string expected = "SjuSjösjukaSjömän";

            string result = StringUtils.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test__Removes_Numbers()
        {
            string input    = "17 sjuka sjömän sjunger 7 sjuka sånger";
            string expected = "SjukaSjömänSjungerSjukaSånger";

            string result = StringUtils.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test__Replaces_Periods()
        {
            string input    = "noll. ett. två. tre. fyra.";
            string expected = "Noll_Ett_Två_Tre_Fyra_";

            string result = StringUtils.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test__Input_Is_Only_Digits()
        {
            string input    = "1 2 3 4 5";
            string expected = string.Empty;

            string result = StringUtils.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test__OMG_EDGE_CASE()
        {
            string input    = "5a";
            string expected = "A";

            string result = StringUtils.Capitalize(input);

            Assert.AreEqual(expected, result);
        }
    }
}
