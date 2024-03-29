﻿using System.ComponentModel.DataAnnotations;

namespace MyAppModels
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category? category { get; set; }
    }
}
