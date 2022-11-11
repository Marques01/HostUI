﻿using System.Collections.ObjectModel;

namespace Models
{
    public class Product
    {
        private int
            _productId = default;            

        private string
            _name = string.Empty,
            _imagePath = string.Empty;

        private decimal
            _price = default;

        public int ProductId { get => _productId; init => _productId = value; }        

        public string Name { get => _name; init => _name = value; }

        public string ImagePath { get => _imagePath; init => _imagePath = value; }

        public decimal Price { get => _price; init => _price = value; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<CategoryProduct> CategoriesProducts { get; set; }

        public Product()
        {
            Categories = new Collection<Category>();

            CategoriesProducts = new Collection<CategoryProduct>();
        }
    }
}
