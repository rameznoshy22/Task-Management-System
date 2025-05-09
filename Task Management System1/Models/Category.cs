﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    internal class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //[Required]
        //public int UserId { get; set; } // Add this property

        //[ForeignKey("UserId")]
        //public User User { get; set; } // Navigation property

        // Navigation property
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
