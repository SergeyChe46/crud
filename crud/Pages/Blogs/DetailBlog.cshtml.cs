using crud.Models;
using crud.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crud.Pages.Blogs
{
    public class DetailModel : PageModel
    {
        private readonly Composite _composite;

        public DetailModel(Composite composite)
        {
            _composite = composite;
        }

        public Blog Blog { get; set; }

        public void OnGet(int id)
        {
            Blog = _composite.Blogs.GetByExpression(b => b.Id == id).First();
        }
    }
}
