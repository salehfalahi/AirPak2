using Microsoft.AspNetCore.Identity;

namespace AirPak.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public IFormFile? Photo { get; set; }
        public decimal Price { get; set; }
      
    }
}
