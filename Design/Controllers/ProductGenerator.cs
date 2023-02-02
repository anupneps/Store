using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Controllers
{
    public class ProductGenerator
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public ProductGenerator() 
        {
            Categories = new()
            {
            new Category(1, "Clothes"),
            new Category(2, "Shoes"),
            new Category(3, "Electronics"),
            new Category(4, "Others")
            };

            Products = new()
            {
              new Product(1, "Shoes", 23, "Antislippery winter shoes"),
              new Product(2, "Classy T-Shirt", 50, "Slimfit t-shirt- summer use"),
              new Product(3, "Random jeans", 30, "Blue denim jeans"),
              new Product(4, "Woolen sweater", 20, "Winter warm sweater"),
              new Product(5, "Designer Watch", 23, "Designer Watch"),
            };

            Products[0].AddCategory(Categories[1]);
            Products[1].AddCategory(Categories[1]);
            Products[1].AddCategory(Categories[3]);
            Products[2].AddCategory(Categories[0]);
            Products[2].AddCategory(Categories[0]);
            Products[2].AddCategory(Categories[0]);
            Products[4].AddCategories(Categories);
        }

        public void GetAllProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
            }
        }      
    }
}
