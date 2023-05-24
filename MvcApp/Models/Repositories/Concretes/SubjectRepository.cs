using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Models.Repositories.Concretes
{
    public class SubjectRepository : ISubjectRepository
    {
        protected DbContext Context { get; set; }
        public SubjectRepository(DbContext context)
        {

            Context = context;

        }
        public void Add(Subject subject)
        {
            Context.Entry(subject).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Delete(Subject subject)
        {
            Context.Entry(subject).State = EntityState.Deleted; 
            Context.SaveChanges();
        }

        public Subject Get(string id)
        {
            return Context.Set<Subject>().FirstOrDefault(s => s.Id == Guid.Parse(id));
        }

        public void Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
