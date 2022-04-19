using Microsoft.AspNetCore.Mvc;
using Working_With_Model.Models;
namespace Working_With_Model.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Students stud)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Students stud)
        {
            return View();
        }

        public IActionResult Delete(int id)
        { 
            return View();
        }
        [HttpPost]
        public IActionResult DeleteConform(int id)
        {
            return View();
        }
    }
}
