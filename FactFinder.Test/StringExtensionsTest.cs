using FactFinderBL;

namespace FactFinder.Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        [DataTestMethod]
        [DataRow("test", "es")]
        [DataRow("testing", "t")]
        [DataRow("middle", "dd")]
        [DataRow("A", "A")]
        [DataRow("abcdef", "cd")]
        public void GetMiddle_ReturnsCorrectMiddleCharacters(string input, string expectedOutput)
        {
            string actualOutput = input.GetMiddle();

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [DataTestMethod]
        [DataRow("# Header", "<h1>Header</h1>")]
        [DataRow("## Header", "<h2>Header</h2>")]
        [DataRow("###### Header", "<h6>Header</h6>")]
        [DataRow("####### Header", "####### Header (too many hashes)")]
        [DataRow("#######  Header", "#######  Header (too many spaces between)")]
        [DataRow("Header", "Header (no hashes)")]
        public void GetHTMLHeader_ReturnsCorrectHtml(string input, string expectedOutput)
        {
            string actualOutput = input.GetHTMLHeader();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}