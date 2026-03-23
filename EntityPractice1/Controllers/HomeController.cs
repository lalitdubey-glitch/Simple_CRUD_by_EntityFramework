using EntityPractice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace EntityPractice1.Controllers
{
    public class HomeController : Controller
    {
        DBLayer db = new DBLayer();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Student(int? sr, int?id)
        {
            if (sr.HasValue)
            {
                StudentModel st = db.Students.Find(sr.Value);
                return View(st);
            }

            if (id.HasValue)
            {
                StudentModel student = db.Students.Find(id.Value);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    return Content("<script>alert('Data Deleted'); location.href='/home/Student/'</script>");
                }
            }

            List<StudentModel> stu = db.Students.ToList();
            ViewBag.data = stu;
            return View();
        }
        [HttpPost]
        public ActionResult Student(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (s.Id!=0)
                    {
                        db.Entry(s).State = EntityState.Modified;
                        db.SaveChanges();
                        return Content("<script>alert('Data Updated'); location.href='/home/Student/'</script>");
                    }
                    else
                    {
                        db.Students.Add(s);
                        db.SaveChanges();
                        return Content("<script>alert('Data Saved'); location.href='/home/Dashboard/'</script>");
                    }
                        
                }
                catch(Exception ex)
                {
                    ViewBag.ex = ex.Message;
                    return View(s);
                }
            }
            return View(s);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}