using AutoMapper;
using crud.Models.ViewModels;
using crud.Models;

namespace crud.Services.Mapping
{
    public class AuthorMapper
    {
        public static Author MappedAuthor(RegisterAuthorViewModel authorViewModel)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RegisterAuthorViewModel, Author>()
                    .ForMember(dst => dst.Email, src => src.MapFrom(o => o.Email));
            });
            var mapper = new Mapper(config);
            Author newAuthor = mapper.Map<Author>(authorViewModel);
            return newAuthor;
        }
    }
}
