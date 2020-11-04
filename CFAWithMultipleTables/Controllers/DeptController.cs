using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CFAWithMultipleTables.Models;
namespace CFAWithMultipleTables.Controllers
{
    public class DeptController : Controller
    {
        EmpContext obj = new EmpContext();
        // GET: Dept
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Models.Dept> ie = obj.Depts.ToList();
            TempData["Dept"] = ie;
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Dept e1, string b1)
        {
            if (b1 == "Save")
            {
                obj.Depts.Add(e1);
                obj.SaveChanges();
            }
            else if (b1 == "Update")
            {
                Dept d = obj.Depts.Find(e1.Dno);
                d.Dname = e1.Dname;
                obj.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Dept d = obj.Depts.Find(id);
            obj.Depts.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("Index","Dept");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            TempData.Keep();
            Models.Dept d = obj.Depts.Find(Id);
            obj.SaveChanges();
            return View("Index", d);
        }
    }
}