using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
        private static IWebDriver _webDriver;

        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return _webDriver; }
        }

        public static void GoTo(string url)
        {
            _webDriver.Url = url;
        }

        public static void Initialize()
        {
            _webDriver = new FirefoxDriver();
        }

        public static void Close()
        {
            _webDriver.Close();
        }
    }
}