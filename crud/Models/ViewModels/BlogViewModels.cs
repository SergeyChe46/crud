namespace crud.Models.ViewModels
{
    public class BlogViewModels
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string AuthorId { get; set; }
        public ICollection<Tag>? Tags { get; set; }
    }
}
