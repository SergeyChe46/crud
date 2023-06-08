using crud.Models;
using crud.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Composite _composite; 
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, Composite composite)
        {
            _logger = logger;
            _composite = composite;
        }

        public List<Blog> Blogs { get; set; }

        public void OnGet()
        {
            Blogs = _composite.Blogs.GetAll().ToList();
        }
    }
}