// See https://aka.ms/new-console-template for more information
using Store;
using Store.Controllers;
using Store.Models;
using Store.Services;


Console.WriteLine("Welcome to My Store !");
Console.WriteLine("// LoginDetails: 'Email': Doe@mail.com, 'Password':1234 // ");

var uservalidation = new UserValidation();
Utility.BorderLine();
uservalidation.ValidateEmail();
uservalidation.ValidatePassword();

Console.WriteLine();
Console.WriteLine($"Welcome + {uservalidation.currentUser.Name}");
Console.WriteLine();

// var userInterface = new UserInterface();
userInterface.Dashborad();


Console.WriteLine("Thank you! Have a nice day !");
