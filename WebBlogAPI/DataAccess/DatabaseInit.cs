using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebBlogAPI.DataAccess
{
    public class DatabaseInit
    {
        public static void INIT(IServiceProvider ServiceProvider)
        {
            var context = new DatabaseContext(ServiceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>());
            context.Database.EnsureCreated();
        }
    }
}