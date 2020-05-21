using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E2E_SkillEvaluationTest.Data;
using E2E_SkillEvaluationTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E2E_SkillEvaluationTest.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
        }

        // GET: Todo/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                return View("Details", _context.Todos.ToList().First(i => i.Id == id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }

        }

        // GET: Todo/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                _context.Todos.Add(new Todo { Title = collection["Title"], Completed = bool.Parse(collection["Completed"].First()) });
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: Todo/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                return View(_context.Todos.ToList().First(i => i.Id == id));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }       
        }

        // POST: Todo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Todo entity = _context.Todos.Where(t => t.Id == id).FirstOrDefault();

                entity.Title = collection["Title"];
                entity.Completed = bool.Parse(collection["Completed"].First());
                _context.SaveChanges();

                return Details(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: Todo/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Todo entity = _context.Todos.Where(t => t.Id == id).FirstOrDefault();

                _context.Todos.Remove(entity);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: Todo/MarkFinished/5
        [HttpGet]
        public ActionResult MarkFinished(int id)
        {
            try
            {
                Todo entity = _context.Todos.Where(t => t.Id == id).FirstOrDefault();
                entity.Completed = true;
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

    }
}