// See https://aka.ms/new-console-template for more information
using CoffeShops.Abstract;
using CoffeShops.Concrete;

BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { FirstName="Ömer Faruk", DateOfBirth= new DateTime(2001,05,16),LastName="Didin",NationalityId="3388344"});
Console.ReadLine();