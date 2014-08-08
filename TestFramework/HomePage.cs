using System.Collections.Generic;

namespace TestFramework
{
    public class HomePage
    {
        private const string Url = "http://pluralsight.com";

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
    }
}