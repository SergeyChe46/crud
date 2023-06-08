using crud.Models;
using crud.Repository;

namespace crud.Services
{
    public class Composite
    {
        private readonly ApplicationContext _context;
        private readonly BaseRepository<Blog> _blogRepository;
        private readonly BaseRepository<Author> _authorRepository;

        public Composite(ApplicationContext context)
        {
            _context = context;
            _blogRepository = new BlogRepository(context);
            _authorRepository = new AuthorRepository(context);
        }

        public BaseRepository<Blog> Blogs => _blogRepository;
        public BaseRepository<Author> Authors => _authorRepository;

        public async Task Save() => await _context.SaveChangesAsync();
    }
}
