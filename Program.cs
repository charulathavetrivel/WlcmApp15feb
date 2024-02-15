// See https://aka.ms/new-console-template for more information
using WlcmApp15feb;

Console.WriteLine("Welcome to Authentication App");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@123"));

