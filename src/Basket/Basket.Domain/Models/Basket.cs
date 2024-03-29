﻿using System.ComponentModel.DataAnnotations;

namespace Basket.Domain.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Amount { get; set; }       

        [Required] 
        public DateTime Create { get; set; }

        public DateTime? Delete { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public bool Active { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
