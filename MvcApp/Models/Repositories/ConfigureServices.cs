using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Context;
using MvcApp.Models.Repositories.Abstracts;
using MvcApp.Models.Repositories.Concretes;

namespace MvcApp.Models.Repositories
{
    public static class ServiceRegistration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContext<MvcDbContext>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IAdvisorRepository, AdvisorRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }
    }
}
