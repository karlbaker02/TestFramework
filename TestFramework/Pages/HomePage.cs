using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace TestFramework
{
    public class HomePage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement authorsLink;

        protected override string Url
        {
            get { return "http://pluralsight.com"; }
        }

        protected override List<string> PageTitle
        {
            get
            {
                return new List<string>()
                {
                    "Pluralsight",
                    "Pluralsight – Hardcore Developer and IT Training" // AB Test Variant
                };
            }
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