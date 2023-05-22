using MvcApp.Models.Entities;

namespace MvcApp.Models.Repositories.Abstracts
{
    public interface IAdvisorRepository
    {
        public Advisor Add(Advisor advisor);
        public Advisor Update(Advisor advisor);
        public Advisor Delete(Advisor advisor);
        public Advisor Get(string id);
    }
}
