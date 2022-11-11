using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentList1.Models;
namespace StudentList1.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>();

        [HttpGet]
        public IActionResult Create()
        {
            Student student = new Student();
            return View(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(students);
        }
    }
}