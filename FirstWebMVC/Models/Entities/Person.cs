using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class Person
    {
        [Key]
        public string FullName {get; set;}
        public string Address {get; set;}
        public string? Email {get; set;}
    }
}





