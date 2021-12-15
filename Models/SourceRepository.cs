using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSSAPP.Models
{
    public class SourceRepository
    {
        private readonly RssAppDbContext _db;

        public SourceRepository()
        {
            _db = new RssAppDbContext();
        }

        public void AddSource(Source source)
        {
            _db.Sources.Add(source);
            _db.SaveChanges();
        }

        public Source FindSource(string sourceID)
        {
            return _db.Sources.Find(sourceID);
        }

        public List<Source> GetAllSource()
        {
            return _db.Sources.ToList();
        }
    }
}
