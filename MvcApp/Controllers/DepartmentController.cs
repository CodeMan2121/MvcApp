using Microsoft.AspNetCore.Mvc;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Controllers
{
    
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Add(Department department)
        {
            _departmentRepository.Add(department);
            return View();
        }
        public IActionResult Delete(Department department)
        {
            _departmentRepository.Delete(department);
            return View();
        }
        public IActionResult Update(Department department)
        {
            _departmentRepository.Update(department);
            return View();
        }
        public IActionResult Get(string id)
        {
            _departmentRepository.Get(id);
            return View();
        }
    }
}
