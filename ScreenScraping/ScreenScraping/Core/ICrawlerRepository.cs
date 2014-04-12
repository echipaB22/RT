using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ScreenScraping.Core.Domain;
using System.Data.Entity.Infrastructure;

namespace ScreenScraping.Core
{
    public interface ICrawlerRepository
    {
        Database Database { get; }

        void Add(Records record);
        void Delete(Records record);

        IEnumerable<Records> GetBySiteName(string site);


        void SaveChanges();
    }
}