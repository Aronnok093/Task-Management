﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}