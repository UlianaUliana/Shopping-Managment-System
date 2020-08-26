using ShoppingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingSystem.Data
{
    public class SampleData
    {
        public static void Initialize(ShoppingContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Butter",
                    Price = 30.0
                },
                new Product
                {
                    Name = "Bread",
                    Price = 18.5
                },
                new Product
                {
                    Name = "Milk",
                    Price = 20.0
                },
                new Product
                {
                    Name = "Chocolate",
                    Price = 25.5
                },
                new Product
                {
                    Name = "Apples",
                    Price = 15.0
                }
            );
            context.SaveChanges();

            context.Customers.AddRange(
                new Customer
                {
                    FirstName = "Oksana",
                    LastName = "Ivaniuk",
                    Address = "Ivano-Frankivsk",
                    Discount = 5
                },
                new Customer
                {
                    FirstName = "Ivan",
                    LastName = "Slobodian",
                    Address = "Lviv",
                    Discount = 10
                },
                new Customer
                {
                    FirstName = "Ivanna",
                    LastName = "Tomyn",
                    Address = "Chernivtsi",
                    Discount = 15
                }
            );
            context.SaveChanges();

            context.SuperMarkets.AddRange(
                new SuperMarket 
                { 
                    Name = "Silpo", 
                    Address = "Ivano-Frankivsk, Golovna,254 str." 
                },
                new SuperMarket 
                { 
                    Name = "ATB", 
                    Address = "Chernivtsy, Komarova,3 str." 
                },
                new SuperMarket 
                { 
                    Name = "Metro", 
                    Address = "Lviv, Vilshunu,10 str." 
                },
                new SuperMarket 
                { 
                    Name = "Epicentr", 
                    Address = "Nadvirna, Xotunska,15 str." 
                }
            );
            context.SaveChanges();

            context.Orders.AddRange(
                new Order 
                { 
                    CustomerId = 1, 
                    SuperMarketId = 1, 
                    OrderDate = DateTime.Parse("2020-08-24") 
                },
                new Order
                {
                    CustomerId = 2,
                    SuperMarketId = 2,
                    OrderDate = DateTime.Parse("2020-08-25")
                }
            );
            context.SaveChanges();

            context.OrderDetails.AddRange(
                new OrderDetail 
                { 
                    OrderId = 1, 
                    ProductId = 1, 
                    Quantity = 2 
                },
                new OrderDetail 
                { 
                    OrderId = 1, 
                    ProductId = 2, 
                    Quantity = 5 
                },
                new OrderDetail 
                { 
                    OrderId = 1, 
                    ProductId = 4, 
                    Quantity = 1 
                }
            );
            context.SaveChanges();
        }
    }
}
