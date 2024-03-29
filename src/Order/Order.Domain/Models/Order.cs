﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Domain.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool EmailSend { get; set; }

        [Required]
        public DateTime Create { get; set; }     
        
        public DateTime? Update { get; set; }        

        [Required]
        public int PaymentId { get; set; }

        [ForeignKey("Basket")]
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
