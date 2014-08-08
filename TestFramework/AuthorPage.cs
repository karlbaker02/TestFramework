using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "div h1")]
        private IWebElement authorName;

        public string AuthorName
        {
            get { return authorName.Text; }
        }
    }
}