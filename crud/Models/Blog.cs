using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public DateTime EditedAt { get; set; } = DateTime.Now;
        public Author? Author { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
