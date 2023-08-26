using WolfBlog.DAL.Models.Response.Tags;

namespace WolfBlog.DAL.Repositories.IRepositories
{
    public interface ITagRepository
    {
        HashSet<Tag> GetAllTags();
        Tag GetTag(Guid id);
        Task AddTag(Tag tag);
        Task UpdateTag(Tag tag);
        Task RemoveTag(Guid id);
        Task<bool> SaveChangesAsync();
    }
}
