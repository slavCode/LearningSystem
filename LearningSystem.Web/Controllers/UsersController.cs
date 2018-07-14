namespace LearningSystem.Web.Controllers
{
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Service;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class UsersController : Controller
    {
        private readonly IUserService users;
        private readonly ICourseService courses;
        private readonly UserManager<User> userManager;

        public UsersController(
            IUserService users,
            ICourseService courses,
            UserManager<User> userManager)
        {
            this.users = users;
            this.courses = courses;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Profile(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);

            var profile = await this.users.ByIdAsync(user.Id);
            if (profile == null) return BadRequest();

            var role = this.userManager.GetRolesAsync(user).Result.FirstOrDefault();
            profile.Role = role;

            return View(profile);
        }

        [Authorize]
        public async Task<IActionResult> Certificate(int courseId)
        {
            var userId = this.userManager.GetUserId(User);
            var courseFriendlyName = await this.courses.GetCourseFriendlyNameAsync(courseId);

            var certificate = await this.users.GetCertificateAsync(courseId, userId);
            if (certificate == null) return BadRequest();

            return File(certificate, "application/pdf",
            $"{courseFriendlyName}-{DateTime.Now:MMMM-dd-yyyy}.pdf");
        }
    }
}
