namespace Online_Platform.Areas.Identity.Pages.Account
{
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.WebUtilities;
    using Online_Platform.Models;
    using Online_Platform.Infrastructure.Extensions;
    using Online_Platform.Infrastructure.Configurations;

    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public ConfirmEmailModel(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return this.RedirectToPage("/Index");
            }

            var user = await this._userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code)); // NB!

            var result = await this._userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                this.TempData.AddErrorMessage(string.Join(" ", result.Errors.Select(e => e.Description)));
                //throw new InvalidOperationException($"Error confirming email for user with ID '{userId}':");
            }

            return this.Page();
        }
    }
}
