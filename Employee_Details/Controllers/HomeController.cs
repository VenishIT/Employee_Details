using Employee_Details.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Details.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee  emp = new Employee();
            emp.Designation_List = new SelectList(new List<Designation>() { new Designation { Designation_Id = 1, Designation_Name = "Dot net Developer" } }, "Designation_Id", "Designation_Name");
            emp.Department_List = new SelectList(new List<Department>() { new Department { Department_Id = 1, Department_Name = "IT" } }, "Department_Id", "Department_Name");
            ViewBag.message = "SUCCESS";
            return View(emp);
        }        
    }
}
