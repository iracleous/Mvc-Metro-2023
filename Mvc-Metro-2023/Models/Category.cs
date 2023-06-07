namespace Mvc_Metro_2023.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Person> Persons { get; set; }= new List<Person>();
    }
}
