using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenScraping.Core
{
    public interface ICrawler
    {
        void Crawl(IHtmlDocumentLoader loader, ICrawler context);
    }
}