using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScreenScraping.Core.Domain
{
    public class Records
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Location { get; set; }
    }
}