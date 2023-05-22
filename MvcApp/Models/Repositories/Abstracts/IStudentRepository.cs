using MvcApp.Models.Entities;

namespace MvcApp.Models.Repositories.Abstracts
{
    public interface IStudentRepository
    {
        public Student Add(Student student);
        public Student Delete(Student student);
        public Student Update(Student student);
        public Student Get(string id);
    }
}
