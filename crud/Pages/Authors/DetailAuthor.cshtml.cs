using crud.Models;
using crud.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crud.Pages.Authors
{
    public class DetailAuthorModel : PageModel
    {
        private readonly Composite _composite;

        public DetailAuthorModel(Composite composite)
        {
            _composite = composite;
        }

        public Author Author { get; set; }

        public void OnGet(int id)
        {
            Author = _composite.Authors.GetByExpression(a => a.Id == id).First();
        }
    }
}
