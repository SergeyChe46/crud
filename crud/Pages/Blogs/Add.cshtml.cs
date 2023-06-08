using crud.Models;
using crud.Models.ViewModels;
using crud.Services;
using crud.Services.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crud.Pages.Blogs
{
    public class AddModel : PageModel
    {
        private readonly Composite _composite;
        private readonly BlogMapper _blogMapper;

        public AddModel(Composite composite, BlogMapper mapper)
        {
            _composite = composite;
        }

        [BindProperty]
        public BlogViewModels Blog { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var newBlog = BlogMapper.MappedBlog(Blog);
            await _composite.Blogs.Create(newBlog);
            await _composite.Save();
            return RedirectToPage("/Index");
        }
    }
}
