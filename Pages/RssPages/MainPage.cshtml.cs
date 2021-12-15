using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RSSAPP.Models;

namespace RSSAPP.Pages.RssPages
{
    public class SourceViewModel
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public int Priority { get; set; }
    }
    public class MainPageModel : PageModel
    {
        [BindProperty]
        public SourceViewModel ViewModel { get; set; }
        private SourceRepository _sourceRepository;
        private SourceService _sourceService;

        public MainPageModel(SourceRepository sourceRepository, SourceService sourceService)
        {
            ViewModel = new SourceViewModel();
            _sourceRepository = sourceRepository;
            _sourceService = sourceService;
        }
        [BindProperty]
        public List<Source> sources { get; set; }
        [BindProperty]
        public List<SelectListItem> selectedSources { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public string selectedSource { get; set; }
        public void OnGet()
        {
            sources=_sourceRepository.GetAllSource();
            sources = _sourceService.ListPriority(sources);
            selectedSources = sources.Select(a => new SelectListItem
            {
                Value = a.ID,
                Text = a.Name
            }).ToList();

        }
        public void OnPostSave()
        {

        }
    }
}
