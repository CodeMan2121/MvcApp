using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Models.Repositories.Concretes
{
    public class AdvisorRepository : IAdvisorRepository
    {
        protected DbContext Context { get; set; }
        public AdvisorRepository(DbContext context)
        {
            Context = context;
        }
        public Advisor Add(Advisor advisor)
        {
            Context.Entry(advisor).State = EntityState.Added;
            Context.SaveChanges();
            return advisor;
        }

        public Advisor Delete(Advisor advisor)
        {
            Context.Entry(advisor).State = EntityState.Deleted;
            Context.SaveChanges();
            return advisor;
        }

        public Advisor Get(string id)
        {
            return Context.Set<Advisor>().FirstOrDefault(d => d.Id == Guid.Parse(id));
        }

        public Advisor Update(Advisor advisor)
        {
            Context.Entry(advisor).State = EntityState.Modified;
            Context.SaveChanges();
            return advisor;
        }
    }
}
