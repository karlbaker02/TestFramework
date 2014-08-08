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
            Browser.Initialize();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}