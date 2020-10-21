using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TasksProject.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Level { get; set; }
        public string Term { get; set; }
        public DateTime LanchDate { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Photo { get; set; }

    }
}