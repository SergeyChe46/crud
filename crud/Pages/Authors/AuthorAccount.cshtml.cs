using crud.Models;
using crud.Models.ViewModels;
using crud.Services.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace crud.Pages.Authors
{
    public class AuthorAccountModel : PageModel
    {
        private readonly UserManager<Author> _userManager;
        private readonly SignInManager<Author> _signInManager;

        public AuthorAccountModel(UserManager<Author> userManager,
                                  SignInManager<Author> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public RegisterAuthorViewModel Model { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(RegisterAuthorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Author author = AuthorMapper.MappedAuthor(viewModel);
                // добавляем пользователя
                var result = await _userManager.CreateAsync(author, viewModel.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(author, false);
                    await Console.Out.WriteLineAsync("OK");
                    return RedirectToPage("/Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return BadRequest(result);
                }
            }
            await Console.Out.WriteLineAsync("NE OK");
            return BadRequest();
        }
    }
}
