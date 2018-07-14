namespace LearningSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static Core.GlobalConstants;

    [Area(AdminArea)]
    [Authorize(Roles = AdministratorRole)]
    public class BaseAdminController : Controller
    {
    }
}
