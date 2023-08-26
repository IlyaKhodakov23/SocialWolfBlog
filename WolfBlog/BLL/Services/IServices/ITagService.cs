using WolfBlog.DAL.Models.Request.Tags;
using WolfBlog.DAL.Models.Response.Tags;

namespace WolfBlog.BLL.Services.IServices
{
    public interface ITagService
    {
        Task<Guid> CreateTag(TagCreateRequest model);
        Task EditTag(TagEditRequest model);
        Task RemoveTag(Guid id);
        Task<List<Tag>> GetTags();
    }
}
