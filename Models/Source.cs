using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSSAPP.Models
{
    public class Source
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get;  set; }
        public string URL { get;  set; }
        public int Priority { get;  set; }

    }
}
