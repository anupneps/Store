// See https://aka.ms/new-console-template for more information
using Store;
using Store.Controllers;
using Store.Models;
using Store.Services;

var dummyProductGenerator = new ProductGenerator();
var dummyUserGenerator = new UserGenerator();

var productProvider = new ProductProvider(dummyProductGenerator);
var userProvider = new UserProvider(dummyUserGenerator);

var userInterface = new UserInterface(productProvider, userProvider);
userInterface.Dashborad();

