namespace Online_Platform.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Online_Platform.Infrastructure.Constant;

    [Area(WebConstants.AdminArea)]
    [Authorize(Roles = WebConstants.AdministratorRole)]
    public abstract class BaseAdminController : Controller
    {
    }
}
