using AutoMapper;
using WolfBlog.DAL.Models.Request.Comments;
using WolfBlog.DAL.Models.Request.Posts;
using WolfBlog.DAL.Models.Request.Tags;
using WolfBlog.DAL.Models.Request.Users;
using WolfBlog.DAL.Models.Response.Comments;
using WolfBlog.DAL.Models.Response.Posts;
using WolfBlog.DAL.Models.Response.Tags;
using WolfBlog.DAL.Models.Response.Users;

namespace WolfBlog.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterRequest, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.UserName));

            CreateMap<CommentCreateRequest, Comment>();
            CreateMap<CommentEditRequest, Comment>();
            CreateMap<PostCreateRequest, Post>();
            CreateMap<PostEditViewModel, Post>();
            CreateMap<TagCreateRequest, Tag>();
            CreateMap<TagEditRequest, Tag>();
            CreateMap<UserEditRequest, User>();
        }
    }
}
