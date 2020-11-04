using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFAWithMultipleTables.Models;

namespace CFAWithMultipleTables.Controllers
{
    public class EmployeeController : Controller
    {
        EmpContext obj = new EmpContext();
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            foreach (var item in obj.Depts)
            {
                li.Add(new SelectListItem() { Text = item.Dname, Value = item.Dno.ToString() });
            }
            TempData["dept"] = li;
            TempData.Keep();

            TempData["e"] = obj.Emps.ToList();
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Employee e1, FormCollection f)
        {
            e1.Dno = Convert.ToInt32(f["dept"]);
            obj.Emps.Add(e1);
            obj.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }

    }
}