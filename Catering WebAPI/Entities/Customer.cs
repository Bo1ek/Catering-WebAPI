using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catering_WebAPI.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [MaxLength(20,ErrorMessage = "Name cannot be greater than 20 characters!")]
        [MinLength(3,ErrorMessage = "Name cannot be less than 3 characters!")]
        public required string Name { get; set; }
        [MaxLength(20, ErrorMessage = "Surname cannot be greater than 20 characters!")]
        [MinLength(3, ErrorMessage = "Surname cannot be less than 3 characters!")]
        public required string Surname { get; set; } 
        public string Email { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public List<Order> Orders { get; set; }
    }
}
