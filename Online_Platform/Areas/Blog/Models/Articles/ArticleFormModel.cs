namespace Online_Platform.Areas.Blog.Models.Articles
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using Online_Platform.Models.WebModels;
    using Online_Platform.Services.Blog.Models;
    using System.ComponentModel.DataAnnotations;
    

    public class ArticleFormModel : IMapFrom<ArticleEditServiceModel>
    {
        public int Id { get; set; } = int.MinValue; // invalid Id for Create

        [Required]
        [StringLength(DataConstants.ArticleTitleMaxLength,
            ErrorMessage = DataConstants.StringMinMaxLength,
            MinimumLength = DataConstants.ArticleTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(DataConstants.ArticleContentMaxLength,
            ErrorMessage = DataConstants.StringMinMaxLength,
            MinimumLength = DataConstants.ArticleContentMinLength)]
        public string Content { get; set; }

        public FormActionEnum Action { get; set; } = FormActionEnum.Create; // default Create
    }
}
