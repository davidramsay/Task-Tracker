using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskTrackerPrototype.Data;
using TaskTrackerPrototype.Models;

namespace TaskTrackerPrototype.Controllers
{
    public class DashboardController : Controller         
    {
        private readonly TaskTrackerContext _context;

        public DashboardController(TaskTrackerContext context)
        {
            _context = context;
        }

        // GET: Dashboard
        public async Task<IActionResult> Index(int userID)
        {
            IQueryable<string> tasksQuery = from t in _context.Task
                                            orderby t.TaskName
                                            select  t.TaskName;
            var taskers = from t in _context.Task
                          select t;

            var tasksVM = new TasksViewModel
            {
                /*UserID = await tasksQuery.Distinct().ToListAsync(),*/
                Tasks = await taskers.ToListAsync()
            };

            return View(tasksVM);
        }

        // GET: Dashboard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Task
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Dashboard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskName,TaskDescription,ObjectiveID,TaskDueDate")] Tasker tasker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tasker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasker);
        }


        // GET: Dashboard/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasker = await _context.Task.FindAsync(id);
            if (tasker == null)
            {
                return NotFound();
            }
            return View(tasker);
        }

        // POST: Dashboard/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskID,TaskName,TaskDescription,TaskDueDate,ObjectiveID")] Tasker tasker)
        {
            if (id != tasker.TaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(tasker.TaskId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tasker);
        }
        private bool TaskExists(int id)
        {
            return _context.Task.Any(e => e.TaskId == id);
        }

      
    }
}
