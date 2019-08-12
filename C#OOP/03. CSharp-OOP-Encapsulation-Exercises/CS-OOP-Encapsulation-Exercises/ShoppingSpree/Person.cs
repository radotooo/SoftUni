﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name , decimal money)
        {
            this.Name = name;
            this.Money = money;
            bagOfProducts = new List<Product>();
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts.AsReadOnly();
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }

           private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");

                }
                this.money = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if(string.IsNullOrEmpty(value )|| string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public string ChekIfCanBought( Product product)
        {

            if(this.Money >= product.Price)
            {
                this.Money -= product.Price;
                this.bagOfProducts.Add(product);
                return $"{this.Name} bought {product.Name}";
            }
            else
            {
                return $"{this.Name} can't afford {product.Name}";

            }
        }

       
    }
}
