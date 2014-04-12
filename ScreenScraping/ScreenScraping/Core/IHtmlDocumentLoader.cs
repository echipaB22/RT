using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace ScreenScraping.Core
{
    public interface IHtmlDocumentLoader
    {
        HtmlDocument LoadDocument(string url);
    }
}