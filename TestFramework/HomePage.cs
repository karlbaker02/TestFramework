using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace TestFramework
{
    public class HomePage
    {
        private const string Url = "http://pluralsight.com";

        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement authorsLink;

        private static readonly List<string> PageTitle = new List<string>()
        {
            "Pluralsight",
            "Pluralsight – Hardcore Developer and IT Training" // AB Test Variant
        };

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return PageTitle.Contains(Browser.Title);
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);

            return authorPage.AuthorName == authorName;
        }

        public void SelectAuthor(string authorName)
        {
            authorsLink.Click();

            var author = Browser.Driver.FindElement(By.LinkText("Matt Milner"));
            author.Click();
        }
    }
}