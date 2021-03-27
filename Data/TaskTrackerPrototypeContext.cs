using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskTrackerPrototype.Models;

namespace TaskTrackerPrototype.Data
{
    public class TaskTrackerContext : DbContext
    {
        public TaskTrackerContext (DbContextOptions<TaskTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Tasker> Task { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Objective> Objective { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Goal> Goal { get; set; }
    }
}
