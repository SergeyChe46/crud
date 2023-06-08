using AutoMapper;
using crud.Models;
using crud.Models.ViewModels;
using Microsoft.AspNetCore.Routing.Constraints;

namespace crud.Services.Mapping
{
    public class BlogMapper
    {
        public static Blog MappedBlog(BlogViewModels blogViewModel)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BlogViewModels, Blog>()
                    .ForMember(dst => dst.Title, src => src.MapFrom(o => o.Title))
                    .ForMember(dst => dst.Content, src => src.MapFrom(o => o.Content));
            });
            var mapper = new Mapper(config);
            Blog newBlog = mapper.Map<Blog>(blogViewModel);
            return newBlog;
        }
    }
}
