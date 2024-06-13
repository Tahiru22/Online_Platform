using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Blog.Models
{
  

    public class ArticleDetailsServiceModel : ArticleListingServiceModel, IMapFrom<Article>
    {
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public string AuthorUsername { get; set; }

        public string AuthorEmail { get; set; }
    }
}
