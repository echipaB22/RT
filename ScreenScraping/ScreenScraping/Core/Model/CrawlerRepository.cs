using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ScreenScraping.Core.Domain;

namespace ScreenScraping.Core.Model
{
    internal class CrawlerDataContext : DbContext
    {
        public CrawlerDataContext() : base("crawlerdb")
        {
            
        }

        public DbSet<Records> Records { get; set; }
    }

    public class CrawlerRepository : ICrawlerRepository
    {
        private readonly CrawlerDataContext _context = new CrawlerDataContext();

        public void Add(Records record)
        {
            _context.Records.Add(record);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Database Database
        {
            get { return _context.Database; }
        }


        public void Delete(Records record)
        {
            _context.Records.Remove(record);
        }

        public IEnumerable<Records> GetBySiteName(string site)
        {
            //return _context.Records.Where(r => r.Site == site);
            return null;
        }
    }
}