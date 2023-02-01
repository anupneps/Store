using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; } 
        // public Cart CartItem { get; set; }

        public Product(int id, string title, int price, string description)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Categories = new List<Category>();
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
            //Categories.AddRange(categories);
        }

        public override string ToString()
        {
            return $" Id : {Id}, Title: {Title}, Price: {Price}, Description: {Description}, Categories: {Categories}";
        }


    }


}
