using crud.Repository;

namespace crud.Models
{
    public class BlogRepository : BaseRepository<Blog>
    {
        public BlogRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
