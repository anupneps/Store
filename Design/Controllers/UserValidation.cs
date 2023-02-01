using Store.Models;
using Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class UserValidation
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public User currentUser;
        public void ValidateEmail()
        {
            Console.WriteLine("Enter your credential to log in.");
            Console.Write("Email: ");
            while (true)
            {
                try
                {
                    Email = Console.ReadLine();
                    var users = new UserGenerator();
                    currentUser = users.Users.FirstOrDefault(x => x.Email == Email);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Incorrect Email ! Please Try again !"); }
                }
                catch
                {
                    Console.WriteLine("Invalid Email !");
                }
            }
            Utility.BorderLine();
        }
        public void ValidatePassword()
        {
            Console.Write("Password: ");
            while (true)
            {
                try
                {
                    Password = Console.ReadLine();
                    var users = new UserGenerator();
                    if (currentUser.Password == Password) { break; }
                    else { Console.WriteLine("Incorrect Password !"); }
                }
                catch
                {
                    Console.WriteLine("Incorrect Password !");
                }
            }
            Utility.BorderLine();
        }
    }
}
