using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RSSAPP.Models;

namespace RSSAPP.Pages.RssPages
{
    public class SourceInputModel
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public int Priority { get; set; }
    }
    public class FirstPageModel : PageModel
    {
        [BindProperty]
        public SourceInputModel InputModel { get; set; }
        private SourceRepository _sourceRepository;
        private SourceService _sourceService;

        public FirstPageModel(SourceRepository sourceRepository, SourceService sourceService)
        {
            InputModel = new SourceInputModel();
            _sourceRepository = sourceRepository;
            _sourceService = sourceService;
        }
        [BindProperty]
        public int Value { get; set; }

        public void OnGet()
        {
            
        }
        public void OnPostSave()
        {
            Source source = new Source();
            source.Name = InputModel.Name;
            source.URL = InputModel.URL;
            source.Priority = InputModel.Priority;
            _sourceService.AddSource(source);
        }
    }
}
