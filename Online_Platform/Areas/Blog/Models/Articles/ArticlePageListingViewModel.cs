namespace Online_Platform.Areas.Blog.Models.Articles
{
    using Online_Platform.Models.WebModels;
    using Online_Platform.Services.Blog.Models;
    using System.Collections.Generic;
   

    public class ArticlePageListingViewModel
    {
        public IEnumerable<ArticleListingServiceModel> Articles { get; set; }

        public PaginationViewModel Pagination { get; set; }

        public SearchViewModel Search { get; set; }
    }
}
