using WolfBlog.DAL.Models.Request.Comments;
using WolfBlog.DAL.Models.Request.Posts;
using WolfBlog.DAL.Models.Response.Posts;

namespace WolfBlog.BLL.Services.IServices
{
    public interface IPostService
    {
        Task<PostCreateRequest> CreatePost();
        Task<Guid> CreatePost(PostCreateRequest model);
        Task<PostEditViewModel> EditPost(Guid Id);
        Task EditPost(PostEditViewModel model, Guid Id);
        Task RemovePost(Guid id);
        Task<List<Post>> GetPosts();
        Task<Post> ShowPost(Guid id);
    }
}
