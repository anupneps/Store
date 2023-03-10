using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public int Id { get; init; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public int Quantity { get; set; }
        
        public Product(int id, string title, int price, string description)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Categories = new List<Category>();
            Quantity = 1;
        }

        public void AddCategory(Category category)
        {
            var foundCategory = Categories.FirstOrDefault(cat => cat.Id == category.Id);
            if (foundCategory != null) return;
            Categories.Add(category);
        }

        public void AddCategories(List<Category> categories)
        {
            foreach(var category in categories) { AddCategory(category);}
        }

        public void GetCategories()
        {
            foreach (var category in Categories ) 
            {
                Console.WriteLine(category);
            }
        }

        public override string ToString()
        {
            var category = string.Join(", ", Categories);
            return $" Id : {Id}, Title: {Title}, Price: {Price}, Description: {Description}, Categories: {category}";
        }
    }


}
