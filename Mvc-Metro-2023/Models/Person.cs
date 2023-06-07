using System.ComponentModel.DataAnnotations;

namespace Mvc_Metro_2023.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }  
        public DateTime DateOfBirth  { get; set; }
        public virtual Category? Category { get; set; }
    }
}
