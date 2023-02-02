namespace Store.Models
{
    public class Cart
    {
        public List<Product> Products = new List<Product>();
        public User User;
        public int Quantity { get; set; }
        
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public void AddUser(User user)
        {
            User = user;
        }
        public void CartDetail()
        {
            Console.WriteLine($"Hello {User.Name}, Here is your Cart details.");
            Console.WriteLine($"There are {Products.Count} item/s in the cart:");
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}