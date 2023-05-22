using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Models.Repositories.Concretes
{
    public class DepartmentRepository : IDepartmentRepository
    {
        protected DbContext  Context { get; set; }
        public DepartmentRepository(DbContext context) { 
            Context = context;
        }
        public void Add(Department department)
        {
            Context.Entry(department).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Delete(Department department)
        {
            Context.Entry(department).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public Department Get(string id)
        {
            return Context.Set<Department>().FirstOrDefault(d => d.Id == Guid.Parse(id));
        }

        public void Update(Department department)
        {
            Context.Entry(department).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
