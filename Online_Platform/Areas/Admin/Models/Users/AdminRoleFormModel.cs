namespace Online_Platform.Areas.Admin.Models.Users
{
    using System.ComponentModel.DataAnnotations;
   
    using Online_Platform.Models;
    using Online_Platform.Models.WebModels;

    public class AdminRoleFormModel
    {
        [Required]
        [StringLength(DataConstants.RoleNameMaxLength,
            ErrorMessage = DataConstants.StringMaxLength)]
        [Display(Name = "Role")]
        public string Name { get; set; }

        public FormActionEnum Action { get; set; } = FormActionEnum.Create;
    }
}
