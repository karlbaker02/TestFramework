using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class TestPage
    {
        [TestInitialize]
        public void Setup()
        {
            Browser.Initialize("http://localhost");
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}