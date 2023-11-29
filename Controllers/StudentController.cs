using Microsoft.AspNetCore.Mvc;
using Model_Binding_2___Modelde_Belirli_Alanları_Doldurmak.Models;

namespace Model_Binding_2___Modelde_Belirli_Alanları_Doldurmak.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(Student student)
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return View("Index", student);
        }
    }
}
