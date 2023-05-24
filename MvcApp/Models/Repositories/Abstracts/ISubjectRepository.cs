using MvcApp.Models.Entities;

namespace MvcApp.Models.Repositories.Abstracts
{
    public interface ISubjectRepository
    {
        public void Add(Subject subject);
        public void Delete(Subject subject);
        public void Update(Subject subject);
        public Subject Get(string id);
    }
}
