namespace Theoistic.Arxiv.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Feed? feed = ArxivParser.Category(ArxivCategory.ArtificialIntelligence);
            Assert.IsNotNull(feed);
        }
    }
}