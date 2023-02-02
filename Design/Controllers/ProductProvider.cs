using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{  
    public class ProductProvider 
    {
        private ProductGenerator _generator { get; set; }
        public Cart Cart { get; set; } = new Cart();
        
        public ProductProvider(ProductGenerator generator)
        {
            _generator= generator;
            
        }
        public List<Product> GetProducts() { return _generator.Products; }
        
        public Cart GetCart(User user)
        {
            return Cart;
        }
        public bool AddToCart(string id)
        {
            var foundProduct = GetProducts().FirstOrDefault(p => p.Id.ToString() == id);
            if(foundProduct == null) { return false; }
            else if (Cart.Products.Contains(foundProduct)){
                foundProduct.Quantity++;
                return true;
            }
            Cart.AddProduct(foundProduct);
            return true;
        }
    }
}
