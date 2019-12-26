using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> emplist = new List<Employee>() {
            new Employee() { EmpId = 1, EmpName = "Emp 1" }
            ,new Employee() { EmpId = 2, EmpName = "Emp 2" }
            ,new Employee() { EmpId = 3, EmpName = "Emp 3" }
            };
        // GET: Home
        public ActionResult Index()
        {
            
            return View(emplist);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            Employee e = emplist.FirstOrDefault(x => x.EmpId == id);
            return View(e);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            // commented edit post action
            //emplist.Add(e);
            return View("Index", emplist);
        }
    }
}