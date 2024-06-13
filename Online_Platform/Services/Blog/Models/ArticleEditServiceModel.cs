using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Blog.Models
{
   

    public class ArticleEditServiceModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
