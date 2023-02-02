using Store.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class UserInterface
    {
        private string _email { get; set; } = string.Empty;
        private string _password { get; set; } = string.Empty;
        private ProductProvider _productProvider { get; set; }
        private UserProvider _userProvider { get; set; }

        public UserInterface(ProductProvider productProvider, UserProvider userProvider)
        {
            _productProvider = productProvider;
            _userProvider = userProvider;
        }

        public void ShowUserCredentialInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Email: ");
                    _email = Console.ReadLine();
                    if (_email == string.Empty)
                    {
                        Console.WriteLine("email cannot empty");
                        continue;
                    }
                    Console.Write("Password: ");
                    _password = Console.ReadLine();
                    if (_password == string.Empty)
                    {
                        Console.WriteLine("Password cannot empty");
                        continue;
                    }

                    if (_userProvider.ValidateAndSetUser(_email, _password)) { break; }
                        Console.WriteLine("Incorrect! Please Try again! or press 1 to exit");
                        var input = Console.ReadLine();
                        if (input == "1") { break; }   
                }
                catch
                {
                    Console.WriteLine("Invalid Email or Password !");
                }
            }
            Utility.BorderLine();
        }

        public void Dashborad()
        {
            Console.WriteLine("Welcome to My Store !");
            Console.WriteLine("// LoginDetails: 'Email': Doe@mail.com, 'Password':1234 // ");
            Console.WriteLine("Enter your credential to log in.");
            ShowUserCredentialInput();

            Console.WriteLine();
            var userName = _userProvider.GetCurrentUser() == null ? "Guest" : _userProvider.GetCurrentUser().Name;
            Console.WriteLine($"Welcome {userName}");
            Console.WriteLine();

            Console.WriteLine("Thank you! Have a nice day !");

            Utility.BorderLine();
            Console.WriteLine("Please choose the following options:");
            Console.WriteLine("1. Show All Product");
            Console.WriteLine("2. Add to cart");
            Console.WriteLine("3. Show Cart");
            Console.WriteLine("4. Show User Profile");
            Console.WriteLine("5. Exit");
            Utility.BorderLine();

            int option = 0;
            do
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) 
                {
                   ShowAllProducts();
                }
                else if (option == 2) 
                {
                    ShowAddToCart();
                }
                else if (option == 3) 
                {
                    ShowCartItems();
                }
                else if (option == 4)
                {
                    ShowUserProfile();
                }
                else if (option == 5) { break; }
                else { option = 0; }
            }
            while (option != 5);
        }

        public void ShowAllProducts()
        {
            foreach (var item in _productProvider.GetProducts())
            {
                Console.WriteLine(item);
            }
        }

        public void ShowCartItems()
        {
            foreach (var item in _productProvider.GetCart(_userProvider.GetCurrentUser()).Products)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Quanitity: {item.Quantity.ToString()}");
            }
        }

        public void ShowUserProfile()
        { 
            var currentUser = _userProvider.GetCurrentUser();
            if(currentUser == null)
            {
                Console.WriteLine("Please log In");
                return;
            }
            Console.WriteLine(currentUser.Name);
            Console.WriteLine(currentUser.Email);
            Console.WriteLine(currentUser.Role);
        }

        public void ShowAddToCart()
        {
            Console.Write("Enter product ID: ");
            var input = Console.ReadLine();
            if (_productProvider.AddToCart(input))
            {
                Console.WriteLine("**Product Added to cart**");
                return; 
            }
            Console.WriteLine("Product not found!");
        }
    }
}
