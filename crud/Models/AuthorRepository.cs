using crud.Repository;

namespace crud.Models
{
    public class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
