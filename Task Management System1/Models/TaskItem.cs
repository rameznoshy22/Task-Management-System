using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    internal class TaskItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Due date must be today or a future date.")]
        public DateTime DueDate { get; set; }

        [Required]
        [RegularExpression("^(Low|Medium|High)$", ErrorMessage = "Priority must be Low, Medium, or High.")]
        public string Priority { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
// Custom validation attribute for future date
public class FutureDateAttribute : ValidationAttribute 
{
    public override bool IsValid(object value)
    {
        DateTime date = (DateTime)value;
        return date >= DateTime.Today;
    }
}
public enum TaskStatus
{
    Pending = 0,
    InProgress = 1,
    Completed = 2
}