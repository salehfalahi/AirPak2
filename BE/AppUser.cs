using System.Security.Principal;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
namespace BE
{
    public class AppUser : IdentityUser
    { 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
    public class Click
    {
        public int Id { get; set; }
        public DateTime ClickTime { get; set; }
    }

}