using Microsoft.AspNetCore.Mvc;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IActionResult Add(Student student)
        {
            _studentRepository.Add(student);
            return View();
        }
        public IActionResult Delete(Student student)
        {
            _studentRepository.Delete(student);
            return View();
        }
        public IActionResult Update(Student student)
        {
            _studentRepository.Update(student);
            return View();
        }
        public IActionResult Get(string id)
        {
            _studentRepository.Get(id);
            return View();
        }
    }
}
