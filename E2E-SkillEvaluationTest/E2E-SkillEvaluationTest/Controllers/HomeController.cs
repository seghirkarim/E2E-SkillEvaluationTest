using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E2E_SkillEvaluationTest.Models;
using E2E_SkillEvaluationTest.Data;
using Microsoft.EntityFrameworkCore;

namespace E2E_SkillEvaluationTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoContext _context;

        public HomeController(TodoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Todos.ToListAsync());
        }

        //This method is called for searches in the alternative table. 
        // Source: https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-3.1
        public async Task<IActionResult> IndexManual(string sortOrder, string searchString)
        {
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["TitleSortParm"] = sortOrder == "title" ? "title_desc" : "title";
            ViewData["CompletedSortParm"] = sortOrder == "completed" ? "completed_desc" : "completed";
            ViewData["CurrentFilter"] = searchString;

            var todos = from s in _context.Todos
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                todos = todos.Where(s => s.Title.Contains(searchString)
                                       || s.Id.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "id_desc":
                    todos = todos.OrderByDescending(s => s.Id);
                    break;
                case "title":
                    todos = todos.OrderBy(s => s.Title);
                    break;
                case "title_desc":
                    todos = todos.OrderByDescending(s => s.Title);
                    break;
                case "completed":
                    todos = todos.OrderBy(s => s.Completed);
                    break;
                case "completed_desc":
                    todos = todos.OrderByDescending(s => s.Completed);
                    break;
                default:
                    todos = todos.OrderBy(s => s.Id);
                    break;
            }

            return View("IndexManual", await todos.AsNoTracking().ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
