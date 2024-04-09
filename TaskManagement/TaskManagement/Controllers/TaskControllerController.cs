using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class TaskControllerController : Controller
    {
        private TaskDbContext db = new TaskDbContext();
        // GET: TaskController
        public ActionResult Index()
        {
            var data = db.Tasks.ToList();
            return View(data);
        }

        //GET Task/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST TASK/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}