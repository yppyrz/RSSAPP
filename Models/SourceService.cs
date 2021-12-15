using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSSAPP.Models
{
    public class SourceService
    {
        SourceRepository _sourceRepository;
        public SourceService(SourceRepository sourceRepository)
        {
            _sourceRepository = sourceRepository;
        }

        public void AddSource(Source source)
        {
            if (source == null)
            {
                throw new Exception("Haber kaynağı boş olamaz.");
            }
            if (string.IsNullOrEmpty(source.Name) || string.IsNullOrEmpty(source.URL) || (source.Priority < 1 || source.Priority > 4))
            {
                throw new Exception("Haber kaynağı bilgileri boş olamaz.");
            }
            source.Name = source.Name.Trim();
            source.URL = source.URL.Trim();

            _sourceRepository.AddSource(source);
        }
        public List<Source> ListPriority(List<Source> sources)
        {
            return sources.OrderByDescending(x => x.Priority).ToList();
        }
    }
}
