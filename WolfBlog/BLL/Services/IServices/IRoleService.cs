using WolfBlog.DAL.Models.Request.Roles;
using WolfBlog.DAL.Models.Request.Tags;
using WolfBlog.DAL.Models.Response.Roles;
using WolfBlog.DAL.Models.Response.Tags;

namespace WolfBlog.BLL.Services.IServices
{
    public interface IRoleService
    {
        Task<Guid> CreateRole(RoleCreateRequest model);
        Task EditRole(RoleEditRequest model);
        Task RemoveRole(Guid id);
        Task<List<Role>> GetRoles();
    }
}
