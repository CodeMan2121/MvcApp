using MvcApp.Models.Entities;

namespace MvcApp.Models.Repositories.Abstracts
{
    public interface IDepartmentRepository
    {
        public void Add(Department department);
        public void Delete(Department department);
        public void Update(Department department);
        public Department Get(string id);
    }
}
