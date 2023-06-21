using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Abdullah.Models;

namespace Abdullah.Controllers
{
    public class HomeController : Controller

    {
        StudentContext db = new StudentContext();
        //Get : Home
        public ActionResult Index()
        {
            ViewBag.data = db.Students.ToList();
            return View();
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
        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Student emp)
        {
            try
            {
                db.Students.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        { var Students = db.Students.Single(m => m.id == id);
            return View(Students);}

        // POST: Employee/Edit/5
        [HttpPost]
        //        public ActionResult Edit(int id)
        //        {
        //            try
        //            {
        //                var row
        //= db.Students.Single(m => m.id == id);
        //                if (TryUpdateModel(Student s))
        //                {
        //                    //To Do:- database code
        //                    db.SaveChanges();
        //                    return RedirectToAction("Index");
        //                }
        //                return View(Students);
        //            }
        //            catch
        //            {
        //                return View();
        //            }
        //        }
        //public ActionResult Delete(int id)
        //{
        //    var StudentIdRow = db.Students.Where(model => model.id == id).FirstOrDefault();
        //    return View(StudentIdRow);
        //}
 
        //public ActionResult Delete(int ID)
        //{
        //    if(ID == 0 || ID == null)
        //    {
        //        TempData["DeleteMessage"] = "<script>alert('Please Select First To Deleted !!')</script>";
        //    }
        //    else
        //    {
        //        var SingleDelete = db.Students.Where(model => model.id == ID).FirstOrDefault();

        //        db.Entry(SingleDelete).State = System.Data.Entity.EntityState.Deleted;
        //        int a = db.SaveChanges();
        //        if (a > 0)
        //        {
        //            TempData["DeleteMessage"] = "<script>alert('Data Deleted !!')</script>";
        //        }
        //        else
        //        {
        //            TempData["DeleteMessage"] = "<script>alert('Data not Deleted !!')</script>";
        //        }
        //    }
    
        //    return RedirectToAction("Index");
        //}



        public ActionResult Delete(IEnumerable<int> ID)
        {
            Student std = new Student();
            foreach (int id in ID)
            {
                std = db.Students.Find(id);
                db.Students.Remove(std);
                db.SaveChanges();
            }
            return RedirectToAction("Index");}}}