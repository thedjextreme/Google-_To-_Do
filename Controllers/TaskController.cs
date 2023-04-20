using Google_To_Do.Data;
using Google_To_Do.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google_To_Do.Controllers
{
    public class TaskController : Controller
    {

        private readonly ApplicationDbContext _db;

        public TaskController(ApplicationDbContext db)
        {
            _db = db;

        }


        public IActionResult Index()
        {
            IEnumerable<zadanie> objList = _db.zadanie;
            return View(objList);
        }
        //get - create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //post -create
        public IActionResult Create(zadanie obj)
        {
            _db.zadanie.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //get - edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.zadanie.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(zadanie obj)
        {
            if (ModelState.IsValid)
            {
                _db.zadanie.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.zadanie.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.zadanie.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.zadanie.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
