using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
        static readonly IWebDriver _webDriver = new FirefoxDriver();

        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static void GoTo(string url)
        {
            _webDriver.Url = url;
        }

        public static void Close()
        {
            _webDriver.Close();
        }
    }
}