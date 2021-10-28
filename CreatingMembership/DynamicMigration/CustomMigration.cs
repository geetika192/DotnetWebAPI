using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CreatingMembership.Data;

namespace CreatingMembership.DynamicMigration
{
    public static  class CustomMigration
    {
        public static void MigrationInitialization(this IApplicationBuilder iapp)
        {
            using(var scope=iapp.ApplicationServices.CreateScope())
            {
                scope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}