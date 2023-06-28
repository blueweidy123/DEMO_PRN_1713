using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        //day la 1 action trong 1 controller
        public IActionResult Index(Student s)
        {
            //xu li du lieu
            //c3: truyen model

            return View(s);
        }

        static List<Student> students = new List<Student>();
        public IActionResult Show()
        {
            //truyen du lieu tu controller sang view
            //c1-ViewData
            ViewData["Message"] = "truyen du lieu bang ViewData:";
            ViewData["Data"] = new Student()
            {
                Code = "01",
                Name = "An Trieu",
                Age = 20
            };

            //c2-ViewBag
            ViewBag.Message1 = "Truyen du lieu bang ViewBag";
            ViewBag.Data1 = new Student()
            {
                Code = "02",
                Name = "An tt",
                Age = 21
            };

            ViewBag.lstStu = students;

            //c3-Model
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student s) {
            if (ModelState.IsValid)
            {
                //ViewBag.newStu = new Student()
                //{
                //    Code = s.Code,
                //    Name = s.Name,
                //    Age = s.Age
                //};
                //tao va truyen thanh cong
                students.Add(s);
                return RedirectToAction("Index", s);
                //return RedirectToAction("Show", s);

            }
            else
            {
                //that bai
                return View(s);
            }
        }
    }
}
