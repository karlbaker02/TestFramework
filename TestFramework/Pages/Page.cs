using System.Collections.Generic;

namespace TestFramework
{
    public abstract class Page
    {
        protected abstract List<string> PageTitle { get; }
        protected abstract string Url { get; }

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