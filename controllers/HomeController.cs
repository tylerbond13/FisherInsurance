using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc; 
public class HomeController : Controller 
{
    public IActionResult Index() 
    { 
        return View();

        //return Ok("This is the index of the HomeController"); 
        
    } 
    public IActionResult Quote()
    {
        Quote quote = new Quote 
        { 
            Id = 345, 
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M 
        };
        return View(quote);
    }
    
}