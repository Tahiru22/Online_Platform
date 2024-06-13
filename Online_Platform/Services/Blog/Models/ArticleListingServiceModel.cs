namespace Online_Platform.Services.Blog.Models
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
    public class ArticleListingServiceModel : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorName { get; set; }
    }
}
