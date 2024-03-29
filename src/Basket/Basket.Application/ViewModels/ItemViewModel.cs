﻿namespace Basket.Application.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Create { get; set; }
        public DateTime? Update { get; set; }
        public int ProductId { get; set; }
    }
}
