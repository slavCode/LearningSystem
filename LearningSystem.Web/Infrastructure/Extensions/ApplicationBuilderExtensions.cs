namespace LearningSystem.Web.Infrastructure.Extensions
{
    using Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Service.Implementaions;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app
                .ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<LearningSystemDbContext>();
                context.Database.Migrate();

                var seederService = new SeederService(context, serviceScope);
                Task.Run(async () =>
                {
                    await seederService.RolesAsync();
                    await seederService.UsersAsync();
                    await seederService.CoursesAsync();
                    await seederService.UsersInCourses();
                    await seederService.ArticlesAsync();
                }).Wait();
            }

            return app;
        }
    }
}
