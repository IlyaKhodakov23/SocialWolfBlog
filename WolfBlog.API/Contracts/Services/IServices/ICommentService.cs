using Microsoft.AspNetCore.Mvc;
using WolfBlog.API.Data.Models.Request.Comments;
using WolfBlog.API.Data.Models.Response.Comments;

namespace WolfBlog.API.Contracts.Services.IServices
{
    public interface ICommentService
    {
        Task<Guid> CreateComment(CommentCreateRequest model);
        Task<int> EditComment(CommentEditRequest model);
        Task RemoveComment(Guid id);
        Task<List<Comment>> GetComments();
    }
}
