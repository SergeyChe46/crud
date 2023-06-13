using crud.Models;
using crud.Models.ViewModels;
using crud.Services;
using crud.Services.Mapping;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace crud.Pages.Blogs
{
    public class AddModel : PageModel
    {
        private readonly Composite _composite;

        public AddModel(Composite composite)
        {
            _composite = composite;
        }

        [BindProperty]
        public BlogViewModels Blog { get; set; }

        public async Task<IActionResult> OnPost()
        {
            Blog.AuthorId = User.Identity.GetUserId();
            var newBlog = BlogMapper.MappedBlog(Blog);
            await _composite.Blogs.Create(newBlog);
            await _composite.Save();
            return RedirectToPage("/Index");
        }
    }
}
