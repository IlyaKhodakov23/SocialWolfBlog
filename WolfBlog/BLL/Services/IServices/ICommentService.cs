using Microsoft.AspNetCore.Identity;
using WolfBlog.DAL.Models.Request.Comments;
using WolfBlog.DAL.Models.Request.Users;
using WolfBlog.DAL.Models.Response.Comments;
using WolfBlog.DAL.Models.Response.Users;

namespace WolfBlog.BLL.Services.IServices
{
    public interface ICommentService
    {
        Task<Guid> CreateComment(CommentCreateRequest model, Guid UserId);
        Task EditComment(CommentEditRequest model);
        Task RemoveComment(Guid id);
        Task<List<Comment>> GetComments();
    }
}
