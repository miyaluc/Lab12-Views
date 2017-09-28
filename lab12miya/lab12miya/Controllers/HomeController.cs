using lab12miya.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab12miya.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student student = new Student();
            student.Name = "Raphael";
            student.Class = "Algebra";
            student.Grade = 82;

            Student student2 = new Student
            {
                Name = "Amara",
                Class = "Chemistry",
                Grade = 90
            };

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Saoirse", Class = "Knitting", Grade = 100});
            students.Add(new Student { Name = "Aisling", Class = "Kickboxing", Grade = 98});

            ViewData["students"] = students;
            return View(student);
        }
        public ViewResult Options()
        {
            Student student3 = new Student
            {
                Name = "Damon",
                Class = "Home Economics",
                Grade = 76
            };

            return View(student3);
        }
    }
}
