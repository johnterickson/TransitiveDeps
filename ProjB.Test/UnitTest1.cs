using Newtonsoft.Json;

namespace ProjB.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(
                12,
                typeof(JsonSerializer).Assembly.GetName().Version?.Major);
        }
    }
}