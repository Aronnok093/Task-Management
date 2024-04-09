﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TaskManagement.Models
{
    public class TaskDbContext: DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskDbContext() : base("TaskDbContext") { }
    }
}