using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class Author : IdentityUser
    {
        public ICollection<Blog> Blogs { get; set; }
    }
}