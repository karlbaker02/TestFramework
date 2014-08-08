using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            Browser.Initialize();
        }

        [TestMethod]
        public void CanGoToHomePage()
        {
            Pages.HomePage.GoTo();
            
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void CanGoToAuthorPage()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectAuthor("Matt Milner");
            
            Assert.IsTrue(Pages.HomePage.IsAtAuthorPage("Matt Milner"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}