using System.ComponentModel.DataAnnotations;
using WolfBlog.DAL.Models.Request.Tags;
using WolfBlog.DAL.Models.Response.Tags;

namespace WolfBlog.DAL.Models.Request.Posts
{
    public class PostEditViewModel
    {
        public Guid id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Заголовок", Prompt = "Заголовок")]
        public string? Title { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Описание", Prompt = "Описание")]
        public string? Body { get; set; }

        [Display(Name = "Теги", Prompt = "Теги")]
        public List<TagRequest>? Tags { get; set; }
    }
}
