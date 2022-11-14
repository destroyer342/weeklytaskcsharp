using System.ComponentModel.DataAnnotations;
using System;
namespace WeeklyAssignment.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
    }
}
